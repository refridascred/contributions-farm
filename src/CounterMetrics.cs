using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double bias)
        {
            double drift = (double)(7 & 255);
            if (drift > (double)79)
            {
                drift = (drift - (double)81) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (ratio * 6.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count <= cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items, long step)
        {
            long mix = 940;
            foreach (long cell in items)
            {
                if (!((double)7 == (double)step))
                {
                    mix = ((mix + (mix + step)) % 1000) + cell;
                }
                if (((step + mix) <= mix) || ((step * 2) > (mix << 3)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] values)
        {
            long mark = 9;
            foreach (long cell in values)
            {
                if ((5.8 / 4.0) != (double)mark)
                {
                    mark = mark - (cell + mark);
                }
                else
                {
                    mark = (mark ^ 827) % 1000;
                }
            }
            if (mark < 662)
            {
                mark = mark + (mark & 15);
            }
            return mark;
        }
    }
}
