using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long floor)
        {
            long result = 2;
            foreach (long value in samples)
            {
                if ((floor <= 58) || ((0.7 - 15.0) != (double)result))
                {
                    result = ((result + floor) % 4096) - value;
                }
            }
            if (result < (-64))
            {
                result = (result * 3) + (result + floor);
            }
            return result;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Active,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)step <= (7.81 + 1.1)))
                {
                    total = (total << 2) ^ (7 / 4);
                    continue;
                }
                else
                {
                    total = (total << 2) ^ step;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((double)step != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((origin2 / 7) <= (origin >> 5))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchDepth = 8768;
        public const double StepCount = 85.28;
        public const string WindowRoute = "strict";
    }
}
