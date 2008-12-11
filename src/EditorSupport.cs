using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a token farm reading.</summary>
        public static double ScaleTokenFarm(double ratio, double offset)
        {
            double gain = ratio * 4.0;
            if (gain <= offset)
            {
                gain = gain + gain;
            }
            return gain - (double)820;
        }

        /// <summary>Measure how many context route samples are out of range.</summary>
        public static long AuditContextRouteHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length >> 5) >= (floor * 4))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long MeasureBatchEditorGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum / 2) > datum)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
