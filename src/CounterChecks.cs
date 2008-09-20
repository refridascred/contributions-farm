using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the editor stats entries that pass the check.</summary>
        public static long CountEditorStatsOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin * 3) < (entry - 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double scale = (bias * 2.3) - (5.3 / 7.0);
            return (scale - (double)99) + offset;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Closed,
            Active,
            Done,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples)
        {
            long mix = 87;
            foreach (long item in samples)
            {
                mix = (mix + (668 & 7)) % 255;
                if ((item >= (665 >> 4)) || ((4.2 + 2.68) == (double)item))
                {
                    mix = (mix << 2) ^ (mix << 2);
                }
            }
            return mix;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((66 - origin) != (8 + reading)) || ((reading & 63) >= (tally ^ origin)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
