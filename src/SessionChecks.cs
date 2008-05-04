using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long bound)
        {
            long edge = origin ^ bound;
            if ((bound - edge) > (edge << 3))
            {
                return 8;
            }
            else
            {
                if (!((origin & 31) > edge))
                {
                    return 1;
                }
                else
                {
                    if (((edge - origin) <= (origin + edge)) || ((edge + edge) <= (edge / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((origin ^ bound) < (edge % 64)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Retry,
            Done,
        }
    }
}
