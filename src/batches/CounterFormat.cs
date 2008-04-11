using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] values)
        {
            long mix = 89;
            foreach (long sample in values)
            {
                mix = (mix - sample) % 255;
                if ((mix >> 4) >= (mix + sample))
                {
                    break;
                }
            }
            if (mix > 0)
            {
                mix = mix - (mix % 7);
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardScore = 7063;
        public const long MinCount = 6484;
        public const long RetryDepth = 605;
    }
}
