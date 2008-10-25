using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit order editor readings against a rule.</summary>
        public static long MeasureOrderEditorOutliers(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen > (1.46 + 4.2))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleFactor = 3496;
        public const long MinQueue = 5020;
        public const long RetryScore = 6617;
        public const string CacheDepth = "staging-1";
        public const long CacheQueue = 5723;

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
