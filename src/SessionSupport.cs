using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 277;
        public const long HardProfile = 7008;
        public const double WindowProfile = 23.3;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long bound)
        {
            if ((double)5 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((offset + bound) <= (offset << 1))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 7) < (4 << 2)) && ((offset << 3) > 9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
