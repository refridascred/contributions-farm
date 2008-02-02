using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Score { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Iterate the metrics metric series from a seed.</summary>
        public static long SeriesMetricsMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (score + score)) % 65521;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score + (score + 2)) + (long)i2;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
