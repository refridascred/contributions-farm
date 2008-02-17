using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a already support sample.</summary>
        public static long LocateAlreadySupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 4766;
        public const long MinGraph = 2033;
        public const double BaseGraph = 66.64;

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long floor)
        {
            if ((floor * 3) > floor)
            {
                return 2;
            }
            else
            {
                if ((offset - floor) <= offset)
                {
                    return 7;
                }
                else
                {
                    if ((60 + offset) != (floor / 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every buffer batches entry stays within the limit.</summary>
        public static bool GuardBufferBatchesLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample - seen) <= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
