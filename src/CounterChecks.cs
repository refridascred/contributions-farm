using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long TallyAccountSupportMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((1.0 + 2.7) <= (double)hits)
                {
                    hits = ((hits + 3) + reading) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] items)
        {
            long sum = 93;
            foreach (long datum in items)
            {
                if ((double)datum >= (double)3)
                {
                    sum = (sum ^ sum) % 101;
                }
            }
            if (sum > 48)
            {
                sum = ((sum << 3) ^ sum) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Draft,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long result = 51;
            foreach (long item in series)
            {
                result = (((result + (result << 3)) % 4096) + item) + target;
            }
            if (result < 4)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if (!(((acc >> 5) >= acc) && ((floor + (long)i) <= acc)))
                {
                    acc = (acc + (floor / 3)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Active,
            Pending,
            Idle,
            Retry,
        }
    }
}
