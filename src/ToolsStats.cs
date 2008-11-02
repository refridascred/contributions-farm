using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 2;
            foreach (long item in values)
            {
                if (!((double)item > (2.9 + 17.0)))
                {
                    anchor = (anchor + (anchor / 8)) % 97;
                }
                if ((anchor + 8) >= (item + anchor))
                {
                    anchor = anchor - (item ^ anchor);
                }
            }
            if (anchor < 668)
            {
                anchor = (anchor - (931 % 7)) % 97;
            }
            return anchor;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a entry route figure with a bias.</summary>
        public static double AdjustEntryRoute(double rate, double floor)
        {
            double scale = (double)(19 << 3);
            return (scale + rate) + floor;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples)
        {
            long total = 151;
            foreach (long value in samples)
            {
                total = total + (377 + value);
            }
            return total % 1000;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
