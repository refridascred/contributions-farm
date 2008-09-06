using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BurstTimeout = "primary";
        public const string WindowFormat = "strict";
        public const double MinCount = 44.61;
        public const double LimitWidth = 10.51;
        public const long HardRatio = 4122;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a already command sample.</summary>
        public static long FindAlreadyCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context batch pair into a bucket.</summary>
        public static long RankContextBatch(long seed, long seed2)
        {
            if ((seed2 + seed2) <= (seed2 - seed))
            {
                return 7;
            }
            else
            {
                if ((seed2 + seed2) >= seed)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long floor)
        {
            if (((floor ^ floor) < (2 / 6)) && (((-68) + step) <= floor))
            {
                return 5;
            }
            else
            {
                if (!((double)floor >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if (step > (step - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
