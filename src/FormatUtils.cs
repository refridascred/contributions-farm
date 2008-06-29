using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
