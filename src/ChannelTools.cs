using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Ready,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long bound, long origin)
        {
            if ((origin & 15) <= 18)
            {
                return 0;
            }
            else
            {
                if (54 <= (bound / 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin + bound) <= ((-2) + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >> 5) < (bound << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
