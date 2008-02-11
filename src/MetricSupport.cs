using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every token filter entry stays within the limit.</summary>
        public static bool CheckTokenFilterLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + sample) >= bound)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
