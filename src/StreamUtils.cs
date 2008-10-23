using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Draft,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long step2)
        {
            long cur = step ^ step2;
            if (((7.8 / 9.0) < (double)cur) && ((cur >> 5) == (step2 & 63)))
            {
                return 3;
            }
            else
            {
                if ((step + cur) < (21 >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((19 > (step % 8)) && ((double)cur != (0.04 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((cur << 1) > cur) || ((cur ^ cur) <= (cur << 2)))
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

        /// <summary>Derive the next buffer route value from a seed.</summary>
        public static long RollBufferRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
