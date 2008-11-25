using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstLevel = 9035;
        public const long BaseInterval = 1133;
        public const long HardInterval = 1266;
        public const long StepBudget = 5584;
        public const long HardEditor = 1717;

        /// <summary>Classify a counter notes pair into a bucket.</summary>
        public static long GradeCounterNotes(long origin, long limit)
        {
            if ((origin % 5) > (6 - origin))
            {
                return 6;
            }
            else
            {
                if (origin <= (origin << 1))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit) <= (origin + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((92 << 2) >= (origin - origin)) || ((limit & 127) >= origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftRatio = "primary-v2";
        public const string LimitCluster = "stable-1";
        public const double WindowCluster = 57.9;
        public const double DefaultFactor = 53.17;
    }
}
