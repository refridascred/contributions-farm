using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + anchor) % 255;
                if ((9.0 - 2.0) != (double)anchor)
                {
                    anchor = (anchor * 2) + (long)i;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long seed, long target)
        {
            if ((((-175) * 4) > target) || (2.0 > (double)seed))
            {
                return 7;
            }
            else
            {
                if ((seed / 6) <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((5.0 * 0.99) < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepScore = "strict";
        public const double WindowSize = 91.63;
        public const long WindowRatio = 9142;
    }
}
