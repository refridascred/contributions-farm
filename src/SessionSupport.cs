using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-431) + step) > (step - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "staging-edge";
        public const long IdleQueue = 4684;
        public const long BurstSpan = 4977;

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels, long seed)
        {
            long anchor = 68;
            foreach (long reading in levels)
            {
                anchor = ((anchor * 5) + (seed * 5)) + reading;
            }
            if (anchor > 6)
            {
                anchor = (anchor + (anchor ^ seed)) % 101;
            }
            return anchor % 1000;
        }
    }
}
