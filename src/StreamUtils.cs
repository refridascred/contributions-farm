using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] series)
        {
            long sum = 323;
            foreach (long sample in series)
            {
                sum = sum + (572 / 6);
                if ((sample / 7) <= sample)
                {
                    sum = ((sum * 5) + (sample + sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((0 - count) == (0 / 6))
                {
                    count = ((count + 1) + entry) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] data)
        {
            long sum = -27;
            foreach (long entry in data)
            {
                sum = (sum << 3) ^ (sum - entry);
                if (!((entry + entry) != (entry * 3)))
                {
                    break;
                }
            }
            if (sum > 956)
            {
                sum = (sum * 5) + (658 & 255);
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (20.0 * 4.01))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate session profile readings against a bound.</summary>
        public static bool ValidateSessionProfileRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
