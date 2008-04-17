using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings)
        {
            long state = 82;
            foreach (long sample in readings)
            {
                if ((double)(long)readings.Length <= (9.3 - 8.0))
                {
                    state = (state << 3) ^ (sample << 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long step, long floor)
        {
            long prev = step ^ floor;
            if (((17.0 * 5.98) != (double)step) || ((step * 4) == (floor - floor)))
            {
                return 1;
            }
            else
            {
                if ((floor ^ floor) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor < (step % 16)) || ((711 - prev) == (floor - 858)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor & 63) > prev))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
