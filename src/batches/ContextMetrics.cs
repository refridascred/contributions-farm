using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Draft,
            Done,
            Failed,
            Synced,
        }

        /// <summary>Measure how many format window samples are out of range.</summary>
        public static long TallyFormatWindowMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)entry == (double)matches) && (matches > ((-355) + matches))) && ((17.0 + 16.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a metrics channel value against two limits.</summary>
        public static long SortMetricsChannel(long target, long floor)
        {
            long span = target ^ floor;
            if ((double)target > (double)floor)
            {
                return 4;
            }
            else
            {
                if (((2.8 - 6.14) < (double)target) || ((target << 1) < (span ^ span)))
                {
                    return 3;
                }
                else
                {
                    if ((floor * 3) < (span % 10))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
