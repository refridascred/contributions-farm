using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double span)
        {
            double load = (double)911 * 9.0;
            if (load <= (load - load))
            {
                load = (load - ratio) - span;
            }
            else
            {
                load = load - (double)38;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + 1.36) + (double)(long)i;
            }
            return load + 1.8;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 4627;
        public const long BatchOrder = 2271;
        public const string RetrySpan = "strict-1";
        public const double BaseWidth = 23.66;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long anchor = 940;
            foreach (long cell in readings)
            {
                if (cell <= (anchor + anchor))
                {
                    anchor = ((anchor * 4) + (anchor - (long)readings.Length)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (anchor + 8)) % 4096;
                }
                if ((anchor & 7) > cell)
                {
                    break;
                }
            }
            if (anchor < 330)
            {
                anchor = (anchor + (anchor >> 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
