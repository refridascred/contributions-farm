using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((double)matches > (double)value) || ((double)matches != (7.7 + 18.0))))
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Closed,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long ClassifyCommits(long origin, long target)
        {
            long gap = origin ^ target;
            if ((origin - 9) < gap)
            {
                return 3;
            }
            else
            {
                if ((86 >> 1) < (target + 0))
                {
                    return 7;
                }
                else
                {
                    if (origin > (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ origin) > (target * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((15.0 + 5.0) > (double)sample)
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) >= (long)samples.Length)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
