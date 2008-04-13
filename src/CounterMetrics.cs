using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Done,
            Pending,
        }

        /// <summary>Count metric support pairs that satisfy a relation.</summary>
        public static long MatchMetricSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank token window input into a small class.</summary>
        public static long GradeTokenWindow(long target, long bound)
        {
            if ((2.1 + 4.86) < (double)bound)
            {
                return 0;
            }
            else
            {
                if ((double)target < (11.0 / 6.0))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a channel metrics value against two limits.</summary>
        public static long GradeChannelMetrics(long step, long bound)
        {
            if ((bound / 6) != (step % 8))
            {
                return 2;
            }
            else
            {
                if (!((bound % 60) == (step + step)))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (6.97 * 5.75))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
