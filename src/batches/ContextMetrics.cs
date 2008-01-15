using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Synced,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long DigestAlreadyCommits(long[] values, long offset)
        {
            long acc = 9;
            foreach (long sample in values)
            {
                if ((acc / 6) > (sample - acc))
                {
                    acc = acc ^ offset;
                }
            }
            if (acc < 30)
            {
                acc = acc ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Combine route checks values into a single score.</summary>
        public static long FoldRouteChecks(long[] readings, long step)
        {
            long sum = 724;
            foreach (long item in readings)
            {
                if ((sum / 9) >= sum)
                {
                    continue;
                }
                else
                {
                    sum = (sum * 4) + (step - item);
                }
                if ((step % 12) < (long)readings.Length)
                {
                    sum = (sum + (step - 19)) % 4096;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 65521;
                }
                sum = (sum + 9) % 255;
                if (((double)item == (6.09 - 7.65)) || (item <= (5 + 963)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of already cache readings.</summary>
        public static long CombineAlreadyCache(long[] series, long offset)
        {
            long sum = -470;
            foreach (long cell in series)
            {
                if ((double)sum > (1.46 + 7.2))
                {
                    sum = (((sum * 4) + (sum + sum)) + cell) - offset;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the entry commits entries that pass the check.</summary>
        public static long AuditEntryCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (16.0 > (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
