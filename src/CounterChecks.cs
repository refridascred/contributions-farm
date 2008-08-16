using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series)
        {
            long sum = 3;
            foreach (long cell in series)
            {
                if ((8 + sum) >= sum)
                {
                    sum = (sum ^ cell) % 101;
                }
                else
                {
                    sum = sum - (cell - cell);
                }
            }
            return sum;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches & 3) != (datum * 2))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long TallyToolsEditorGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(3.0 > (double)reading))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((2.7 + 19.0) == (double)value) && ((value + value) != (value ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (datum / 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
