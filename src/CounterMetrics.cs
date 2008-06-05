using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long step)
        {
            if ((step + step) < (3 % 60))
            {
                return 5;
            }
            else
            {
                if (!(origin < (origin * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((2 % 64) >= (step ^ 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)step == (double)origin) || ((step >> 3) <= (origin * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            Failed,
            Ready,
            Done,
        }
    }
}
