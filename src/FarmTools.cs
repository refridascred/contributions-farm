using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                if (!((36 ^ 71) >= (target + target)))
                {
                    mix = (mix << 3) ^ (mix + 444);
                }
                if ((mix - 32) == (target + (-13)))
                {
                    mix = (mix ^ (mix - mix)) % 65521;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Queued,
            Locked,
        }
    }
}
