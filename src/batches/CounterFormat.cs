using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] levels, long offset)
        {
            long score = 106;
            foreach (long sample in levels)
            {
                score = (score - score) ^ sample;
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 5) + (offset / 2)) - (long)i;
                    score = score + offset;
                }
                score = score + score;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowCount = "local-1";
        public const long BaseWidth = 5249;
        public const string BurstBatch = "standard";
        public const string StepBatch = "stable-1";
        public const long CacheBatch = 9148;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long total = 471;
            foreach (long reading in data)
            {
                if ((long)data.Length == ((long)data.Length + reading))
                {
                    total = ((total << 2) ^ (total & 63)) % 65521;
                }
                total = total ^ (reading - 0);
            }
            if (total < 4)
            {
                total = (total << 3) ^ (offset + offset);
            }
            return total % 1000;
        }
    }
}
