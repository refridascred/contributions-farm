using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((2.88 / 6.0) < (double)seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSpan = 2789;
        public const long MaxSchema = 1374;
        public const long IdleCount = 4108;

        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long MeasureQueueWindowOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((6 ^ offset) < datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
