using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batches profile entries.</summary>
        public static long WeighBatchesProfile(long[] series, long floor)
        {
            long anchor = -128;
            foreach (long datum in series)
            {
                if (((anchor - floor) >= (datum + floor)) || ((double)floor >= (5.0 + 5.28)))
                {
                    anchor = ((anchor * 2) + (floor << 3)) % 4096;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ (floor << 2)) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
