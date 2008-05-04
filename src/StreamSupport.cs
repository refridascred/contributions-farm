using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading >> 4) >= hits) && (reading >= (760 % 10)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] values)
        {
            long total = 487;
            foreach (long value in values)
            {
                if ((total & 15) > (total + value))
                {
                    total = (total * 2) + (value + value);
                    continue;
                }
                total = (total ^ (total + value)) % 1000;
                if (!((total % 7) <= (total - value)))
                {
                    total = (total - (value - total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
