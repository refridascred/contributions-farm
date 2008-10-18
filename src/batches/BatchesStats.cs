using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long bound)
        {
            long lane = target + bound;
            if (1 > (lane << 3))
            {
                return 3;
            }
            else
            {
                if ((double)target < (20.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 255) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target > (target * 2)) || ((818 + target) == ((-5) % 64)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((7.1 * 2.92) <= (double)seen)
                {
                    seen = ((seen + 1) + sample) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
