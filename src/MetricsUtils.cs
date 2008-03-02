using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen & 15) > (sample + 993))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long bound)
        {
            long next = limit - bound;
            if ((limit - limit) >= (367 % 7))
            {
                return 4;
            }
            else
            {
                if ((limit % 8) <= (limit - next))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a cluster contributi reading.</summary>
        public static double BlendClusterContributi(double ratio, double floor)
        {
            double bias = ratio - (ratio + 3.35);
            if (bias < bias)
            {
                bias = (bias + 6.3) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (double)14) + (double)(long)i;
            }
            return bias + (bias / 5.0);
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long step)
        {
            if (264 >= (254 + step))
            {
                return 6;
            }
            else
            {
                if ((origin % 2) < (step >> 5))
                {
                    return 3;
                }
                else
                {
                    if (!(7 <= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((origin ^ step) >= step) && ((9.73 / 5.0) == (double)origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
