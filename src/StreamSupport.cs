using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MinFactor = 76.56;
        public const double BatchSchema = 44.82;
        public const string CacheLevel = "fallback-1";
        public const long DefaultSchema = 2716;
        public const string LimitSchema = "legacy-v2";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long step, long bound)
        {
            long delta = step ^ bound;
            if ((bound ^ bound) != (delta ^ step))
            {
                return 4;
            }
            else
            {
                if ((step - bound) == (delta & 15))
                {
                    return 3;
                }
                else
                {
                    if (bound > delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta * 2) >= bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
