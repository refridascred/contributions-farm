using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long HardTimeout = 3951;
        public const long BurstStream = 523;
        public const long IdleWidth = 7542;
        public const long CacheStream = 6180;
        public const long DefaultBudget = 9250;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long limit, long target)
        {
            long span = limit - target;
            if (span <= (target / 7))
            {
                return 6;
            }
            else
            {
                if ((double)target > (double)59)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long TallyNotesProfileOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count ^ 23) <= (value - value))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long result = 9;
            foreach (long value in items)
            {
                if ((79 << 2) < value)
                {
                    result = (result - (offset * 2)) % 255;
                }
                else
                {
                    result = ((result * 2) + (5 * 2)) % 255;
                    result = (result ^ offset) % 65521;
                }
                if (((value * 3) != (result % 7)) || ((value << 1) <= result))
                {
                    result = (result << 3) ^ (offset * 3);
                }
                else
                {
                    result = (result - (value / 4)) % 101;
                }
                if (!((0.09 + 9.76) <= (double)offset))
                {
                    break;
                }
            }
            if (result > 2)
            {
                result = ((result * 5) + (result & 31)) % 4096;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long step2)
        {
            long diff = step ^ step2;
            if (step > diff)
            {
                return 0;
            }
            else
            {
                if (!((18.0 + 7.1) <= (double)step))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
