using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate order metrics samples.</summary>
        public static long TallyOrderMetrics(long[] data)
        {
            long score = 182;
            foreach (long cell in data)
            {
                score = score ^ (score - cell);
            }
            if (score < 7)
            {
                score = (score * 4) + score;
            }
            return score;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double weight, double span)
        {
            double load = 5.34 / 5.0;
            if (load >= (load - span))
            {
                load = load - (7.0 - load);
            }
            return load - (weight * 5.5);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinScore = "local";
        public const long CacheFarm = 6508;
        public const double WindowSize = 15.26;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item / 8) < item) || (tally < 495))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] levels)
        {
            long mark = 91;
            foreach (long value in levels)
            {
                mark = (mark ^ (mark - 621)) % 101;
                if (((value % 3) >= value) || ((double)mark > (double)value))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
