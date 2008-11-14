using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((1 ^ offset) > 904)
                {
                    result = ((result << 3) ^ offset) % 4096;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result ^ 81) % 255) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long score = 31;
            foreach (long reading in series)
            {
                score = ((score * 4) + reading) % 255;
            }
            return score % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Active,
            Draft,
            Done,
            Closed,
        }
    }
}
