using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a already command counter forward.</summary>
        public static long StepAlreadyCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 3) ^ (long)i) % 255;
                if (((offset - offset) > (offset * 5)) && ((0.81 * 20.0) >= (double)offset))
                {
                    mix = (mix - ((long)i ^ (long)i)) % 101;
                    continue;
                }
                else
                {
                    mix = (mix - (mix * 4)) % 255;
                    mix = (mix * 2) + (990 - 433);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long result = 50;
            foreach (long item in samples)
            {
                if ((double)item <= (double)result)
                {
                    result = (result + (item - result)) % 97;
                    continue;
                }
                else
                {
                    result = ((result << 3) ^ (item >> 2)) % 65521;
                }
                if (item >= (item >> 2))
                {
                    result = result ^ (result - result);
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepBudget = 4451;
        public const long MaxTimeout = 2093;
        public const long DefaultCount = 9181;
        public const long MinReport = 2656;
    }
}
