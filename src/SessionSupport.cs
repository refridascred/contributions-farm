using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long origin, long target)
        {
            long cur = origin + target;
            if ((origin ^ origin) == (target / 6))
            {
                return 8;
            }
            else
            {
                if (!((3.9 - 1.69) == (double)cur))
                {
                    return 6;
                }
                else
                {
                    if ((6.6 + 7.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (1.4 * 0.37))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i ^ score) >= score)
                {
                    score = ((score << 3) ^ (score / 4)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
