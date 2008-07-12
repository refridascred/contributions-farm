using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "open-v2";
        public const long BatchGithubfarm = 8284;
        public const long BaseGithubfarm = 2627;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] data)
        {
            long sum = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) < sum)
                {
                    sum = ((sum << 2) ^ (datum - sum)) % 65521;
                }
            }
            if (sum < 13)
            {
                sum = ((sum * 3) + (sum - (long)data.Length)) % 4096;
            }
            return sum;
        }
    }
}
