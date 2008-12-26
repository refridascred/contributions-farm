using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - ((long)i + floor);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next order layout value.</summary>
        public static double ScaleOrderLayout(double weight, double span)
        {
            double load = (double)(45 >> 5);
            for (int i = 0; i < 9; i++)
            {
                load = (load + (span + weight)) + (double)(long)i;
            }
            return load + 4.9;
        }

        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long CountGithubfarmEntryOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)datum < (double)target)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
