using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long floor)
        {
            if ((limit >> 3) >= (42 + limit))
            {
                return 4;
            }
            else
            {
                if (((limit << 2) > (1 + 4)) && ((18.0 * 3.61) < (double)limit))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor >= (9.0 * 9.0)) && ((floor * 4) > (848 - floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.37 * 0.87) <= (double)limit) || ((double)limit > 16.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 60.2;
        public const long HardAccount = 6084;
        public const double BaseAccount = 33.39;
    }
}
