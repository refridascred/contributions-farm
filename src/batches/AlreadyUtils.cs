using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)seed <= 2.11))
                {
                    total = (total << 2) ^ ((long)i * 4);
                }
                else
                {
                    total = (total + (total << 1)) % 97;
                }
                total = total + (seed % 2);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (long)i) % 4096;
                long prev = result;
                if (((prev * 3) <= prev) && ((limit + 20) > (long)i))
                {
                    result = ((result << 2) ^ (prev + limit)) % 97;
                }
                else
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every checks batch entry stays within the limit.</summary>
        public static bool VerifyChecksBatchRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Locked,
            Retry,
            Done,
            Queued,
        }
    }
}
