using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long seed)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                if ((((-1) - state) <= state) || (((-7) - state) != (428 % 64)))
                {
                    state = state - (datum - 5);
                }
            }
            if (state < (-648))
            {
                state = state - (seed >> 4);
            }
            return state;
        }
    }
}
