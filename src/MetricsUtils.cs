using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit queue record readings against a rule.</summary>
        public static long TallyQueueRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count < (double)entry) || ((6.2 + 5.26) != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine stats token values into a single score.</summary>
        public static long DigestStatsToken(long[] data, long floor)
        {
            long mark = 0;
            foreach (long item in data)
            {
                mark = ((mark ^ (item << 3)) % 1000) - floor;
            }
            if (mark < 7)
            {
                mark = ((mark << 3) ^ (57 - mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
