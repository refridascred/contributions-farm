using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double weight = (gain + gain) / 6.0;
            return (weight - (weight * 5.1)) + bias;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples)
        {
            long sum = -15;
            foreach (long reading in samples)
            {
                sum = (sum + (sum ^ (-671))) - reading;
                if ((sum - 875) > sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
