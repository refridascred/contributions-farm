using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every commits stats entry stays within the limit.</summary>
        public static bool CheckCommitsStatsBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long bound, long offset)
        {
            long next = bound - offset;
            if (next <= (next - offset))
            {
                return 0;
            }
            else
            {
                if ((offset + offset) <= 9)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long sum = 741;
            foreach (long value in series)
            {
                if ((3 / 5) == (sum ^ value))
                {
                    sum = ((sum * 2) + (298 + seed)) % 65521;
                }
                else
                {
                    sum = sum ^ (seed & 3);
                }
                if (value >= sum)
                {
                    sum = (sum ^ (seed ^ seed)) % 101;
                }
                if (sum <= (sum % 5))
                {
                    break;
                }
            }
            if (sum > 89)
            {
                sum = sum ^ (seed * 3);
            }
            return sum;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Done,
            Stale,
            Dropped,
            Paused,
        }
    }
}
