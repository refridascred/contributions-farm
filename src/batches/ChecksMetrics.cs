using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values, long target)
        {
            long anchor = 98;
            foreach (long reading in values)
            {
                anchor = (anchor + ((-90) + 3)) % 65521;
                if ((target - reading) != (target * 3))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor + 77);
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 10.4;
        public const long HardNotes = 619;
        public const long BurstScore = 4924;

        /// <summary>Fold a list of queue context readings.</summary>
        public static long TotalQueueContext(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                mark = (((mark << 3) ^ (mark - mark)) + item) - offset;
            }
            return mark;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstTimeout = 3632;
        public const string WindowQueue = "fallback-edge";
        public const double MaxQueue = 35.52;
        public const string BatchQueue = "standard-1";

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 8650;
        public const double RetryDepth = 29.27;
        public const long BatchCommand = 8486;
        public const string SoftSpan = "primary-v2";
    }
}
