using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine stream payload values into a single score.</summary>
        public static long CombineStreamPayload(long[] values, long offset)
        {
            long mix = 86;
            foreach (long datum in values)
            {
                if ((mix % 3) >= (offset * 4))
                {
                    mix = ((mix * 4) + (offset - offset)) + datum;
                }
            }
            if (mix > 4)
            {
                mix = ((mix << 2) ^ (8 ^ 45)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen / 5) >= datum) || ((double)seen < (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two graph entry measurements.</summary>
        public static double SmoothGraphEntry(double rate, double floor)
        {
            double gain = (double)(4 - 12);
            if (gain < floor)
            {
                gain = gain + (rate * 5.18);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (rate / 8.0)) - (double)(long)i;
            }
            return gain + (floor / 8.0);
        }
    }
}
