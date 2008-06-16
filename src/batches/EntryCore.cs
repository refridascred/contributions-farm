using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double span)
        {
            double rate = weight + weight;
            if (rate > rate)
            {
                rate = (rate - 3.96) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (weight - rate)) - (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)seed < 3.93)
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "latest-1";
        public const long MinSpan = 7836;
        public const long StepBatches = 3216;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
