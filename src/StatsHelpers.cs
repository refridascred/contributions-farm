using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long origin)
        {
            if (4.0 <= (double)target)
            {
                return 2;
            }
            else
            {
                if ((origin + origin) == (origin + target))
                {
                    return 3;
                }
                else
                {
                    if ((double)1 < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 0) < (origin - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double weight, double bias)
        {
            double weight2 = 0.4 * 14.0;
            for (int i = 0; i < 5; i++)
            {
                weight2 = (((weight2 - (weight2 * 20.0)) + (double)(long)i) - weight) - bias;
            }
            return weight2 + (weight2 * 6.0);
        }
    }
}
