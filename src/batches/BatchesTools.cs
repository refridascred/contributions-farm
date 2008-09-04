using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double gain, double span)
        {
            double drift = span;
            if (drift > gain)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series, long limit)
        {
            long carry = -61;
            foreach (long reading in series)
            {
                carry = (carry - ((-7) + reading)) % 1000;
                if ((carry <= (carry + limit)) || ((double)reading < 4.47))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
