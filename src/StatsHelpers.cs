using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a stream already pair into a bucket.</summary>
        public static long RankStreamAlready(long bound, long bound2)
        {
            if ((bound2 + bound) <= 120)
            {
                return 2;
            }
            else
            {
                if ((bound2 + 79) != (894 - bound))
                {
                    return 1;
                }
                else
                {
                    if ((21 * 4) == (bound2 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 - bound) != (719 % 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 9137;
        public const long WindowFactor = 6836;
        public const long BatchToken = 9942;
        public const long BatchTimeout = 8297;

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples)
        {
            long sum = 2;
            foreach (long value in samples)
            {
                sum = ((sum * 4) + (long)samples.Length) % 1000;
                if ((double)value >= (17.0 - 3.62))
                {
                    sum = (sum - (value * 5)) % 97;
                }
                else
                {
                    sum = sum - (sum & 63);
                }
            }
            if (sum > 118)
            {
                sum = sum ^ (sum + sum);
            }
            return sum % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Closed,
            Active,
            Done,
            Synced,
        }
    }
}
