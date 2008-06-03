using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Failed,
            New,
        }

        /// <summary>Derive the next checks support value from a seed.</summary>
        public static long SeriesChecksSupport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 2) + (mix & 7)) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long total = 618;
            foreach (long reading in values)
            {
                if ((total - reading) <= reading)
                {
                    total = (total ^ (reading & 63)) % 1000;
                    total = ((total * 5) + reading) % 97;
                    continue;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = (total << 2) ^ (reading + reading);
            }
            if (total > 6)
            {
                total = (total - (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFormat = "local";
        public const double BaseFormat = 71.96;
        public const double MaxWidth = 20.41;
        public const double IdleFormat = 27.41;
    }
}
