using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long seed)
        {
            long step = bound - seed;
            if (!(seed > step))
            {
                return 5;
            }
            else
            {
                if (3.5 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    if (seed >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound + bound) >= (bound & 1)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Pending,
            Draft,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((seen + seen) >= (57 + seen))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
