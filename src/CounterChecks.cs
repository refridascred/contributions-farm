using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                if (((long)series.Length >> 2) != (seed / 7))
                {
                    mix = ((mix - (mix + mix)) % 65521) + reading;
                }
            }
            if (mix > (-59))
            {
                mix = (mix - (seed + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ (carry - limit)) % 101;
                if (carry <= (carry / 4))
                {
                    carry = ((carry << 2) ^ (carry & 15)) % 65521;
                    carry = (carry * 5) + limit;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
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
