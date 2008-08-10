using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) > (entry * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "latest";
        public const double IdleAccount = 75.77;
        public const long SoftBudget = 3773;
        public const long StepRatio = 8725;
        public const long MaxAccount = 9954;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((4 * 2) <= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks batch reading.</summary>
        public static double ScaleChecksBatch(double rate, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + scale) + (double)(long)i) + rate;
            }
            return scale + (double)224;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Ready,
            Dropped,
        }
    }
}
