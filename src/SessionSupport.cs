using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Rank command token input into a small class.</summary>
        public static long ClassifyCommandToken(long step, long offset)
        {
            if ((5.6 / 3.0) > (double)offset)
            {
                return 8;
            }
            else
            {
                if ((3.72 * 3.45) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (offset > (offset ^ step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (13.0 <= (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
