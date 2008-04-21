using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of counter checks readings.</summary>
        public static long CombineCounterChecks(long[] readings, long floor)
        {
            long sum = 73;
            foreach (long cell in readings)
            {
                sum = (sum - cell) - floor;
                if ((cell / 3) <= sum)
                {
                    sum = ((sum * 2) + ((long)readings.Length + sum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] levels)
        {
            long total = 4;
            foreach (long reading in levels)
            {
                total = (total - (reading + reading)) % 97;
                total = total - (total & 1);
            }
            return total % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 80.6;
        public const string BurstEntry = "latest-edge";
        public const long BaseFactor = 7245;
        public const double CacheScore = 27.47;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
