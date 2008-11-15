using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 3541;
        public const string HardDepth = "cached";
        public const long IdleRatio = 1548;
        public const long LimitLevel = 8070;
        public const long RetryToken = 2500;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (step < (datum * 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
