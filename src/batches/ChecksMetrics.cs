using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Synced,
            Draft,
            Closed,
        }

        /// <summary>Combine tools command values into a single score.</summary>
        public static long CombineToolsCommand(long[] samples)
        {
            long sum = -7;
            foreach (long cell in samples)
            {
                sum = (sum + (sum - sum)) ^ cell;
            }
            return sum;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items)
        {
            long sum = 430;
            foreach (long sample in items)
            {
                if (!((sum & 255) == (sum / 5)))
                {
                    sum = sum + (sum % 7);
                }
                else
                {
                    sum = (sum + 1) % 4096;
                }
                if (sample < (sum + sample))
                {
                    break;
                }
            }
            if (sum > 24)
            {
                sum = (sum ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Derive the next checks metrics value from a seed.</summary>
        public static long SeriesChecksMetrics(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                long prev = (step + 0) - acc;
                acc = (acc - (prev + 37)) % 4096;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
