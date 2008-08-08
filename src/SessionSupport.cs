using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + count) <= (count & 7))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 142;
            foreach (long datum in values)
            {
                if (!(mix <= (284 >> 4)))
                {
                    mix = ((mix << 3) ^ (mix * 5)) - datum;
                }
            }
            if (mix > 960)
            {
                mix = (mix + ((long)values.Length ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchInterval = 7534;
        public const string StepWidth = "staging-edge";
        public const string BatchQueue = "fallback-v2";
        public const long BatchCount = 7819;
    }
}
