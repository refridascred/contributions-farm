using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of counter report readings.</summary>
        public static long CompareCounterReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] samples, long step)
        {
            long result = 916;
            foreach (long sample in samples)
            {
                result = (result + step) % 65521;
                if ((step + step) == (step + sample))
                {
                    result = (result ^ (result << 3)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (step + sample)) % 1000;
                }
            }
            if (result > 3)
            {
                result = (result + (result & 3)) % 255;
            }
            return result;
        }
    }
}
