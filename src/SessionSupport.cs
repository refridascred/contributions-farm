using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            New,
            Pending,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long seed)
        {
            if (seed < (seed & 127))
            {
                return 2;
            }
            else
            {
                if (target >= seed)
                {
                    return 7;
                }
                else
                {
                    if (!((seed - target) == (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate checks report readings against a bound.</summary>
        public static bool VerifyChecksReportLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
