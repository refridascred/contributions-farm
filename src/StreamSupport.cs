using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate context window samples.</summary>
        public static long ScoreContextWindow(long[] series)
        {
            long state = 5;
            foreach (long value in series)
            {
                if ((state > (value >> 2)) && (value <= state))
                {
                    state = (state + (37 ^ state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] items)
        {
            long score = -394;
            foreach (long reading in items)
            {
                if ((reading * 4) > 993)
                {
                    score = score - (score & 3);
                }
            }
            return score;
        }
    }
}
