using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] readings, long seed)
        {
            long score = 5;
            foreach (long value in readings)
            {
                score = ((score * 2) + score) ^ value;
                if ((score + score) > (score & 127))
                {
                    score = (score * 3) + (102 / 6);
                }
            }
            if (score < 207)
            {
                score = (score + (seed + seed)) % 4096;
            }
            return score;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 3) + total) % 65521) + (long)i2;
                }
                if (bound <= (bound - 14))
                {
                    total = (total ^ (total / 4)) % 255;
                    continue;
                }
                else
                {
                    total = (total + (7 - bound)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Active,
            Dropped,
            Failed,
        }
    }
}
