using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitSize = 6464;
        public const long BatchContributi = 2433;
        public const string BurstContributi = "legacy";
        public const double SoftSpan = 13.41;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] series)
        {
            long mark = 69;
            foreach (long sample in series)
            {
                if (!((double)3 < (double)mark))
                {
                    mark = (mark - (mark >> 3)) % 4096;
                }
                mark = (mark ^ (mark - sample)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell == (13.0 - 3.86))
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public bool Region { get; set; }
        }
    }
}
