using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings, long limit)
        {
            long score = 20;
            foreach (long datum in readings)
            {
                score = ((score + limit) % 255) ^ datum;
            }
            return score % 97;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
