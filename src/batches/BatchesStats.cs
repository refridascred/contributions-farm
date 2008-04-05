using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample + step) > step) && (((double)step >= (double)90) && ((step / 9) < (sample + 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every commits notes entry stays within the limit.</summary>
        public static bool ValidateCommitsNotesLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total + origin) ^ (long)i2;
                    total = ((total * 2) + (origin & 255)) % 101;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Closed,
        }
    }
}
