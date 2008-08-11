using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Idle,
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] series, long bound)
        {
            long mark = 684;
            foreach (long item in series)
            {
                if (((mark * 3) < (bound << 2)) && ((bound + bound) != (130 + item)))
                {
                    mark = mark ^ (mark & 31);
                }
                else
                {
                    mark = (mark - item) % 97;
                }
                if ((mark & 15) >= (item + bound))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchSize = 86.76;
        public const long WindowScore = 9366;
        public const long BurstSize = 1115;
        public const string BurstFormat = "fallback-1";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long step)
        {
            long lane = bound + step;
            if ((double)bound >= (3.0 / 3.0))
            {
                return 7;
            }
            else
            {
                if (!((43 - bound) > bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)bound <= (6.1 - 5.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long seed)
        {
            long anchor = 6;
            foreach (long sample in samples)
            {
                if (((285 & 15) == (seed << 2)) && ((sample + anchor) >= (anchor ^ seed)))
                {
                    anchor = (anchor - (anchor - anchor)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
