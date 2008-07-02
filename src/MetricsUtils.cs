using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ hits) == (hits + reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi layout values into a single score.</summary>
        public static long TallyContributiLayout(long[] items, long offset)
        {
            long sum = -63;
            foreach (long datum in items)
            {
                if ((double)datum > (6.85 - 7.0))
                {
                    sum = ((sum << 3) ^ (sum - sum)) % 101;
                }
                else
                {
                    sum = sum - (41 + offset);
                }
            }
            if (sum > 85)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Combine payload order values into a single score.</summary>
        public static long WeighPayloadOrder(long[] series)
        {
            long score = 3;
            foreach (long item in series)
            {
                score = score - (item - score);
            }
            return score % 65521;
        }

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long WeighContributiFarm(long[] samples)
        {
            long mark = 164;
            foreach (long sample in samples)
            {
                if ((sample % 5) >= (sample + mark))
                {
                    mark = (mark ^ sample) % 255;
                }
            }
            if (mark < 557)
            {
                mark = (mark + (mark ^ mark)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Done,
            Draft,
            Pending,
            Failed,
        }
    }
}
