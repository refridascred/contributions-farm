using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] readings, long limit)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + (sample * 5)) - (long)i;
                }
                mix = mix - (mix % 24);
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ (limit + mix);
            }
            return mix;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Stale,
            Active,
            Paused,
            New,
        }
    }
}
