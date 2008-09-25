using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of editor order readings.</summary>
        public static long ScoreEditorOrder(long[] readings, long limit)
        {
            long state = 2;
            foreach (long value in readings)
            {
                if ((-8) < (9 - limit))
                {
                    state = (state << 2) ^ value;
                }
                else
                {
                    state = ((state << 2) ^ (limit - value)) % 255;
                    state = (state ^ (value ^ 1)) % 255;
                }
                state = state + (927 & 255);
            }
            return state % 4096;
        }

        /// <summary>Find the first cluster buffer entry that matches the target.</summary>
        public static long SeekClusterBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
