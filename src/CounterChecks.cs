using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            New,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mix = 846;
            foreach (long entry in series)
            {
                mix = (mix - (mix * 2)) ^ entry;
            }
            return mix % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5547;
        public const double BatchBatches = 83.31;
        public const long WindowBatches = 5687;

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] samples)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if ((6.59 - 1.0) > (double)state)
                {
                    state = ((state * 2) + (reading - state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
