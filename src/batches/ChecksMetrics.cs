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

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
