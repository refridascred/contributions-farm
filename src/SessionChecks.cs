using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples, long offset)
        {
            long total = 179;
            foreach (long value in samples)
            {
                total = (((total * 4) + (total * 2)) + value) - offset;
            }
            return total;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine commits order values into a single score.</summary>
        public static long CombineCommitsOrder(long[] samples, long bound)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if ((result >> 4) != (bound * 5))
                {
                    result = (result * 3) + (item & 255);
                }
                else
                {
                    result = (result ^ (266 & 63)) % 255;
                }
            }
            if (result < 2)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
