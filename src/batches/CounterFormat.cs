using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool VerifyChecksEntryLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((96 & 63) < ((long)i + origin)))
                {
                    result = result - (origin << 1);
                    result = ((result * 4) + (long)i) % 4096;
                }
                if ((result <= (8 << 1)) && (19.0 >= (double)result))
                {
                    result = (result << 2) ^ (origin % 12);
                    result = (result ^ (95 - (long)i)) % 65521;
                }
                result = (result - (origin - result)) % 255;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] values)
        {
            long sum = -308;
            foreach (long datum in values)
            {
                if (datum >= (datum / 7))
                {
                    sum = ((sum << 3) ^ (datum << 3)) % 101;
                }
            }
            return sum % 97;
        }
    }
}
