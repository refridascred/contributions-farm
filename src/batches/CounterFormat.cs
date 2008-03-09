using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metric buffer samples are out of range.</summary>
        public static long TallyMetricBufferGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ datum) == (count - datum))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score + origin) % 1000) ^ (long)i2;
                }
                score = ((score * 3) + (score % 8)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Failed,
            Idle,
        }
    }
}
