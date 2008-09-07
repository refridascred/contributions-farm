using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading - count) >= (reading + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 40.72;
        public const double LimitSpan = 38.61;
        public const long CacheSchema = 3676;

        /// <summary>Fold a list of support report readings.</summary>
        public static long TallySupportReport(long[] values)
        {
            long anchor = 931;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor << 3) ^ ((long)i & 127)) % 1000;
                }
                if (!(((-20) / 9) < (anchor - entry)))
                {
                    anchor = (anchor - anchor) % 4096;
                }
            }
            return anchor % 97;
        }
    }
}
