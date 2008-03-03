using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinInterval = 3557;
        public const long BaseWindow = 2699;
        public const string RetryFactor = "local-1";
        public const string HardLevel = "open-edge";

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long floor, long limit)
        {
            long diff = floor ^ limit;
            if (!((34 - diff) >= limit))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (5.17 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((floor <= (floor << 2)) || (floor < diff))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((408 + limit) != (floor - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long score = 26;
            foreach (long entry in readings)
            {
                if ((entry + score) != (entry ^ entry))
                {
                    score = score + score;
                }
            }
            if (score < 718)
            {
                score = (score + (score ^ score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = 25;
            foreach (long datum in series)
            {
                if (((long)series.Length / 3) >= 814)
                {
                    total = ((total << 2) ^ (datum - total)) % 101;
                }
                if ((datum - total) > total)
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
