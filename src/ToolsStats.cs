using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 7438;
        public const long MaxTools = 2844;
        public const long StepTools = 9730;
        public const double MinTools = 16.9;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Idle,
            Draft,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long offset, long step)
        {
            long cur = offset + step;
            if (!((offset ^ cur) == (step & 15)))
            {
                return 2;
            }
            else
            {
                if ((7.0 <= (double)step) && ((double)step > (0.6 * 3.44)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double load = (double)27 + 7.0;
            return ((load - (7.9 * 5.8)) + ratio) + offset;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Offset { get; set; }
            public double Owner { get; set; }
        }
    }
}
