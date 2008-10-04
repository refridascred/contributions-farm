using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels)
        {
            long acc = 0;
            foreach (long sample in levels)
            {
                if (((sample << 1) == (sample / 2)) || (7 < (acc % 16)))
                {
                    acc = (acc ^ (sample * 5)) % 4096;
                }
            }
            if (acc > (-604))
            {
                acc = (acc ^ (acc * 3)) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double gain, double offset)
        {
            double bias = (double)(54 >> 4);
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - offset) + (double)(long)i) - gain;
            }
            return bias + (bias - bias);
        }
    }
}
