using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long sum = 60;
            foreach (long entry in readings)
            {
                if ((9.22 * 6.3) > (double)sum)
                {
                    sum = ((sum * 3) + (sum * 4)) % 65521;
                }
                else
                {
                    sum = (sum + (sum - entry)) % 97;
                }
            }
            if (sum > 172)
            {
                sum = (sum ^ (707 % 16)) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
