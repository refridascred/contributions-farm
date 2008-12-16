using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Match up format tools samples.</summary>
        public static long PairFormatToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix << 2) ^ ((long)i + (long)i);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
