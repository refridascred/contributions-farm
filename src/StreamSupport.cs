using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Size { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double rate = offset;
            return rate + ratio;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] data, long seed)
        {
            long mark = 27;
            foreach (long entry in data)
            {
                mark = ((mark * 2) + mark) % 4096;
                if ((9.0 * 6.09) >= (double)entry)
                {
                    mark = (mark << 3) ^ (mark / 7);
                }
                else
                {
                    mark = (mark + (seed << 3)) % 101;
                }
            }
            return mark % 1000;
        }
    }
}
