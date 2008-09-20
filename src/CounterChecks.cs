using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine format entry values into a single score.</summary>
        public static long CombineFormatEntry(long[] items)
        {
            long total = 898;
            foreach (long cell in items)
            {
                if (((-92) & 7) != (cell + 0))
                {
                    total = (total ^ (cell - total)) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (cell % 12);
                }
            }
            return total;
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
