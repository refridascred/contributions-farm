using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Queued,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long gap = limit ^ floor;
            if ((0 - floor) > (limit - 6))
            {
                return 3;
            }
            else
            {
                if (((floor >> 5) > (limit - 5)) && ((14.0 / 7.0) >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    if (!(limit <= ((-19) % 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(gap <= limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
