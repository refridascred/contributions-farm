using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Count { get; set; }
            public double Score { get; set; }
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
