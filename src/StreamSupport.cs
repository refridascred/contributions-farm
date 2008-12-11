using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long bound)
        {
            long result = 9;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ 365) % 4096) + datum;
                if ((bound << 1) < bound)
                {
                    break;
                }
            }
            if (result > 758)
            {
                result = result ^ (bound & 15);
            }
            return result;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double weight, double offset)
        {
            double weight2 = offset;
            if (weight2 > (weight2 * 3.5))
            {
                weight2 = weight2 + offset;
            }
            return weight2 + weight;
        }
    }
}
