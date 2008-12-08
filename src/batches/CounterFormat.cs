using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                if ((1 < (datum & 7)) || ((double)score >= 7.8))
                {
                    score = ((score << 2) ^ (datum * 2)) % 65521;
                }
            }
            if (score < 26)
            {
                score = ((score << 2) ^ (score - score)) % 65521;
            }
            return score;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 6512;
        public const long WindowFactor = 7882;
        public const double BurstAccount = 35.62;
        public const double IdleAccount = 95.44;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Pending,
            Locked,
        }
    }
}
