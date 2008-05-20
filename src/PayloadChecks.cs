using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((step % 8) > (21 + step)))
                {
                    score = (score + (step / 4)) % 101;
                }
                if (3.0 > (double)score)
                {
                    score = ((score * 5) + (score - (long)i)) % 4096;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Draft,
            Failed,
            Queued,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstCount = 8571;
        public const long CacheSupport = 3557;
        public const long HardSupport = 352;
        public const long CacheWidth = 3340;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Flag { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
