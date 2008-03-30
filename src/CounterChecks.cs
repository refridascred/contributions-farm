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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count << 2) != (count - 44)))
                {
                    count = ((count + 1) ^ datum) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((reading + 287) <= matches) && (reading <= (reading >> 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long total = -244;
            foreach (long sample in samples)
            {
                total = ((total << 3) ^ bound) % 4096;
                total = ((total << 2) ^ (sample + (long)samples.Length)) % 101;
                if ((sample - bound) < total)
                {
                    break;
                }
            }
            return total;
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
