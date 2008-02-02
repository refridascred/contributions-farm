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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((value + tally) > value) && (((707 % 16) > floor) && ((value % 2) != (value << 3))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
