using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)bound < 4.6)
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long offset, long step)
        {
            long delta = offset ^ step;
            if (!((19.0 * 3.0) <= (double)step))
            {
                return 1;
            }
            else
            {
                if ((delta - delta) <= (offset - 153))
                {
                    return 4;
                }
                else
                {
                    if ((46 ^ delta) == (6 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= (offset * 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
