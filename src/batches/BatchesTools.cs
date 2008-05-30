using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor <= (221 << 1)) || (((long)i ^ (long)i) > (anchor + anchor)))
                {
                    anchor = (anchor - ((long)i >> 1)) % 4096;
                    anchor = (anchor + (anchor / 7)) % 97;
                }
                else
                {
                    anchor = (anchor ^ (step + (long)i)) % 1000;
                }
                anchor = (anchor + (step - anchor)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long seed)
        {
            long bound = target + seed;
            if ((double)seed > (5.56 * 15.0))
            {
                return 2;
            }
            else
            {
                if (((8.84 - 9.22) > (double)bound) && ((96 ^ target) >= bound))
                {
                    return 5;
                }
                else
                {
                    if (((bound + seed) == (seed - target)) || ((target + seed) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Paused,
            Queued,
        }
    }
}
