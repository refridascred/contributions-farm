using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!!((state ^ state) != ((long)i - state)))
                {
                    state = ((state * 5) + (long)i) % 4096;
                }
                state = state - (163 % 5);
                if ((state - 7) > state)
                {
                    state = (state * 2) + (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - 20.0;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long limit)
        {
            if (((double)origin > (7.5 + 7.28)) || ((origin & 1) >= origin))
            {
                return 1;
            }
            else
            {
                if (!((origin + origin) >= (-5)))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin >= 8.0) && ((double)origin == (0.48 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of counter order readings.</summary>
        public static long TallyCounterOrder(long[] levels)
        {
            long mix = 773;
            foreach (long value in levels)
            {
                mix = mix ^ (6 >> 3);
                mix = mix ^ 318;
                if ((484 - value) == (mix << 2))
                {
                    break;
                }
            }
            if (mix > 704)
            {
                mix = (mix * 2) + (mix / 6);
            }
            return mix;
        }
    }
}
