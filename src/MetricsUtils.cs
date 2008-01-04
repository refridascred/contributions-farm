using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Closed,
            Dropped,
            Pending,
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
