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

        /// <summary>Adjust a entry tools reading.</summary>
        public static double BlendEntryTools(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 <= (double)637)
            {
                bias2 = (bias2 + scale) + bias;
            }
            return bias2 + scale;
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
