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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Synced,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long floor, long floor2)
        {
            if (!(floor2 >= (floor2 * 4)))
            {
                return 3;
            }
            else
            {
                if ((floor2 - floor) >= (floor2 + floor2))
                {
                    return 8;
                }
                else
                {
                    if ((5.9 - 8.01) > (5.0 - 1.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(floor < (83 >> 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
