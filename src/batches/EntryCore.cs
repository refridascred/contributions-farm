using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double mean = bias;
            if (mean < (gain + gain))
            {
                mean = mean - (bias / 5.0);
            }
            return mean + (gain + mean);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long state = -2;
            foreach (long sample in levels)
            {
                if ((sample <= (94 << 2)) || (state > (sample + state)))
                {
                    state = state ^ (sample / 7);
                }
                state = (state + state) % 4096;
            }
            if (state < 753)
            {
                state = (state ^ (482 * 4)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultSpan = 1307;
        public const long StepAlready = 6794;
        public const double BurstRatio = 96.83;
        public const string BaseFactor = "staging";
    }
}
