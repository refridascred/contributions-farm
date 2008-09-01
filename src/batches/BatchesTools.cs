using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data, long offset)
        {
            long state = 213;
            foreach (long reading in data)
            {
                state = (((state << 3) ^ offset) % 65521) - reading;
            }
            if (state < 25)
            {
                state = (state ^ (990 + offset)) % 1000;
            }
            return state;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
