using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token already value against two limits.</summary>
        public static long SortTokenAlready(long origin, long step)
        {
            if ((9 << 1) < step)
            {
                return 4;
            }
            else
            {
                if ((origin >= (step / 3)) && ((step + step) <= step))
                {
                    return 5;
                }
                else
                {
                    if (!(step > (93 + 0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two batches entry measurements.</summary>
        public static double ScaleBatchesEntry(double ratio, double offset)
        {
            double drift = (offset + 1.05) * 8.16;
            if (drift > drift)
            {
                drift = drift + (ratio / 3.0);
            }
            else
            {
                drift = drift + (ratio / 2.0);
            }
            return drift + 16.0;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] data, long seed)
        {
            long mark = 50;
            foreach (long sample in data)
            {
                if ((sample + seed) != ((long)data.Length - 374))
                {
                    mark = mark + (seed >> 4);
                }
                if (mark < (sample * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
