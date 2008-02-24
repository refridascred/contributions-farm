using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if (2.4 > (double)(long)i)
                {
                    mark = (mark ^ (long)i) % 101;
                }
                if (((long)i - mark) > (target % 3))
                {
                    mark = mark + (target + target);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 15.72;
        public const long SoftBatches = 573;
        public const string HardBatches = "open-1";

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                if (!((floor / 4) <= floor))
                {
                    sum = (sum - sum) % 255;
                    sum = (sum - (floor % 16)) % 255;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
