using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 653;
            foreach (long datum in items)
            {
                if (datum >= (state - 87))
                {
                    state = (state + (state - state)) % 65521;
                }
                else
                {
                    state = (state + (-87)) % 97;
                }
            }
            return state;
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 1678;
        public const double BaseQueue = 31.5;
        public const long DefaultQueue = 2562;
        public const long HardQueue = 2017;
        public const string MaxRatio = "fallback";

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8473;
        public const string LimitProfile = "latest-v2";
        public const double StepProfile = 45.71;
        public const long HardSize = 8411;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftBudget = 1449;
        public const long BaseSpan = 2036;
        public const long RetryCluster = 4926;
        public const long DefaultCluster = 3090;
        public const long BurstCluster = 1630;
    }
}
