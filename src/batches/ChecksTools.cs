using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample + 74) >= (72 / 3)) && (sample >= count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a schema editor reading by value.</summary>
        public static long LocateSchemaEditorIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 5927;
        public const long CacheCount = 309;
        public const string CacheSpan = "standard-v2";
        public const string BurstCount = "standard-v2";
    }
}
