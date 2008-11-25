using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (8.78 * 15.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!(cell > (cell + seen)) && (((cell << 3) >= (83 - seen)) || ((seen / 8) > (cell / 6))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < (cell + cell))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Locate a payload already reading by value.</summary>
        public static long LookupPayloadAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double ratio, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + bias) - (double)(long)i) + ratio;
            }
            return scale + 10.0;
        }
    }
}
