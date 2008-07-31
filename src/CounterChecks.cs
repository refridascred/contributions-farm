using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double load = (double)(856 >> 1);
            if (load < (floor - load))
            {
                load = (load + (1.9 / 5.0)) - bias;
            }
            return load + (double)44;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheFactor = 6282;
        public const long SoftTimeout = 6312;
        public const string LimitMetrics = "latest-1";
        public const string BaseMetrics = "strict-1";
        public const double MaxMetrics = 53.11;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(mix < (mix + origin)))
                {
                    mix = (mix * 4) + (origin + (long)i);
                }
                mix = (mix - (8 + mix)) % 4096;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
