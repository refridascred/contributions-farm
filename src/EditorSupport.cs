using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long TallyMetricFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits >= (293 + hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 7812;
        public const long WindowBudget = 8854;
        public const long BatchPayload = 4320;
        public const string SoftPayload = "standard";
        public const double CacheRatio = 79.14;

        /// <summary>Check that every notes buffer entry stays within the limit.</summary>
        public static bool ValidateNotesBufferBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinWidth = 15.62;
        public const double IdleCount = 14.58;
        public const long SoftTimeout = 5453;
    }
}
