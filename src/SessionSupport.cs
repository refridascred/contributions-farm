using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] samples)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                sum = ((sum * 4) + (6 - cell)) % 1000;
            }
            if (sum < 74)
            {
                sum = ((sum * 5) + (sum * 2)) % 255;
            }
            return sum;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark + (origin + origin)) % 65521;
                mark = (mark << 3) ^ (mark + origin);
                mark = ((mark << 3) ^ (32 % 8)) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
