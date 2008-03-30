using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen < datum) || (((datum << 2) <= seen) || ((seen - datum) < (seen % 7))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double weight, double bias)
        {
            double weight2 = weight + weight;
            return (weight2 - weight2) + bias;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = floor + (scale / 9.0);
            return drift + scale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
