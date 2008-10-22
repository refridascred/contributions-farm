using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((bound - value) < (bound + bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Total { get; set; }
            public bool Region { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = (state - (state - seed)) % 1000;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result * 3) + (91 & 255)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long total = 52;
            foreach (long datum in items)
            {
                if ((double)total != (double)2)
                {
                    total = ((total * 2) + (67 >> 1)) % 4096;
                }
                if (((datum + total) == (datum + datum)) || ((double)datum == (1.0 - 6.6)))
                {
                    break;
                }
            }
            if (total > 14)
            {
                total = total + (total / 3);
            }
            return total;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
