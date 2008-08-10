using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double offset)
        {
            double weight = (scale / 9.0) + scale;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (scale + weight)) + (double)(long)i) - offset;
            }
            return weight - (double)496;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
