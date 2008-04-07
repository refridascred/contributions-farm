using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next graph order value.</summary>
        public static double ScaleGraphOrder(double weight, double floor)
        {
            double load = (double)(7 / 6);
            if (load > 9.0)
            {
                load = (load - (floor * 3.0)) + weight;
            }
            return load - load;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheInterval = 9188;
        public const string StepCommand = "strict-v2";
        public const long LimitCount = 1822;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long acc = 277;
            foreach (long sample in values)
            {
                acc = (((acc << 3) ^ (5 * 4)) % 1000) - origin;
                if ((476 + acc) <= (acc + sample))
                {
                    acc = (acc ^ (25 << 3)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
