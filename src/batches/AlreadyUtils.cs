using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data, long target)
        {
            long anchor = 251;
            foreach (long datum in data)
            {
                anchor = ((anchor + target) % 101) + datum;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 4819;
        public const double RetryCache = 9.0;
        public const long BatchScore = 1388;
        public const long LimitDepth = 3151;

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
