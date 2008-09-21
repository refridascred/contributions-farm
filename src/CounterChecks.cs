using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route profile samples are out of range.</summary>
        public static long CountRouteProfileHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + step) >= (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseChannel = "latest";
        public const long SoftChannel = 4223;
        public const long DefaultRatio = 2568;

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double bias, double bias2)
        {
            double mean = (bias2 / 7.0) * 0.85;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (mean / 9.0)) + (double)(long)i) + bias;
            }
            return mean + (bias2 * 5.72);
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many context metrics samples are out of range.</summary>
        public static long AuditContextMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally & 7) >= (tally * 2)))
                {
                    tally = (tally + 2) + cell;
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
