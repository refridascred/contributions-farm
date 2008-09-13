using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many support metric samples are out of range.</summary>
        public static long CountSupportMetricMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(((hits + hits) >= (value - 6)) || ((step >> 3) > (value % 16))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultTimeout = 1591;
        public const string LimitPayload = "open-edge";
        public const string BurstPayload = "cached";

        /// <summary>Check that every schema payload entry stays within the limit.</summary>
        public static bool GuardSchemaPayloadRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((7.0 - 9.8) != (double)count)
                {
                    count = ((count + 3) + item) + origin;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long target, long target2)
        {
            if ((target + target) >= (target2 + target))
            {
                return 5;
            }
            else
            {
                if ((target2 % 24) != (target2 >> 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
