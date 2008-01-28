using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long mark = 8;
            foreach (long entry in values)
            {
                if ((mark & 15) == (entry + mark))
                {
                    mark = ((mark << 2) ^ (entry * 2)) % 101;
                }
                else
                {
                    mark = (mark ^ 27) % 1000;
                }
                if (((mark % 5) <= (entry ^ mark)) || ((mark + entry) > (mark - mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + sample) > (sample >> 3))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Dropped,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Audit metric entry readings against a rule.</summary>
        public static long TallyMetricEntryHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((cell + count) <= 332) || ((count * 3) < (count - count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardInterval = "standard";
        public const long MinFarm = 9495;
        public const long WindowCount = 1541;
    }
}
