using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 5903;
        public const long CacheChannel = 334;
        public const double IdleChannel = 90.71;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi window value against two limits.</summary>
        public static long RankContributiWindow(long target, long seed)
        {
            if (((target / 5) < (seed << 1)) && ((1.79 / 7.0) > (double)target))
            {
                return 4;
            }
            else
            {
                if ((target + target) != (seed & 255))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 797;
        public const long MaxEntry = 1353;
        public const long MinSize = 2347;
        public const long RetryEntry = 1429;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
