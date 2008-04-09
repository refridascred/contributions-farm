using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long step)
        {
            if (((origin - origin) != (step + (-843))) || (origin < ((-3) - step)))
            {
                return 6;
            }
            else
            {
                if (!((double)step >= (0.8 / 4.0)))
                {
                    return 8;
                }
                else
                {
                    if ((origin / 2) > (step ^ origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long offset)
        {
            if ((offset ^ offset) >= (bound & 3))
            {
                return 1;
            }
            else
            {
                if (bound > (offset & 3))
                {
                    return 8;
                }
                else
                {
                    if ((530 & 15) > offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound - offset) != (bound / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
