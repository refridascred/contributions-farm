using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the counter graph series from a seed.</summary>
        public static long SeriesCounterGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state * 5) + ((long)i / 7);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings)
        {
            long anchor = 235;
            foreach (long entry in readings)
            {
                anchor = anchor - (entry ^ 30);
                if (((anchor + anchor) == (entry % 100)) || ((anchor - anchor) <= (47 + 14)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a metrics metric counter forward.</summary>
        public static long SeriesMetricsMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i * 4)) % 1000;
                sum = (sum << 3) ^ (long)i;
                sum = (sum << 3) ^ (sum * 2);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Queued,
            Synced,
            Paused,
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ (carry % 10)) % 101;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
