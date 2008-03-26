using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double scale = (offset - ratio) - offset;
            if (scale <= (double)58)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (scale - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 2.2) + (double)(long)i;
            }
            return scale + 0.63;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (594 < (cell ^ cell))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
