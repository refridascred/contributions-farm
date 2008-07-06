using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(((value + (-10)) != (matches + value)) && ((value * 5) >= value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next batch payload value.</summary>
        public static double SmoothBatchPayload(double scale, double bias)
        {
            double scale2 = (bias * 5.9) / 4.0;
            for (int i = 0; i < 3; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 - (scale + 4.6);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry & 255) != (5 + step)) && (count >= (entry << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
