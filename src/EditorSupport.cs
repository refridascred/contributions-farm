using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (1.6 + 9.3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series)
        {
            long acc = 894;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc + (acc % 3)) ^ (long)i;
                    acc = acc ^ (468 + sample);
                }
                if ((acc ^ 89) > (acc >> 1))
                {
                    acc = (acc * 4) + (acc + acc);
                }
                else
                {
                    acc = acc - (acc ^ 13);
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count % 10) >= (floor * 2)) || ((double)count > (2.35 * 17.0))) || (((-530) & 63) < (256 ^ value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long AuditClusterGraphMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < count)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
