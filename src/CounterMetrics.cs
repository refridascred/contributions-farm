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

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
