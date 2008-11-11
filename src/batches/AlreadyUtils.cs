using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next metric context value.</summary>
        public static double BlendMetricContext(double gain, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight - (double)93;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (double)2;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                if ((double)anchor < (double)sample)
                {
                    anchor = (anchor ^ (92 + (-155))) % 97;
                }
            }
            return anchor;
        }
    }
}
