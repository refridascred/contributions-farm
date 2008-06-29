using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long TallyOrderEditorGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) > (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Retry,
            Locked,
            Ready,
            Closed,
        }

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum - seen) < (datum << 3))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double scale = 7.79 + (bias2 * 0.35);
            if (scale < bias2)
            {
                scale = (scale + scale) - bias;
            }
            return scale + (double)0;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long bound)
        {
            long sum = 5;
            foreach (long value in levels)
            {
                sum = ((sum + (sum - sum)) + value) + bound;
            }
            if (sum < 4)
            {
                sum = sum ^ (sum / 9);
            }
            return sum;
        }
    }
}
