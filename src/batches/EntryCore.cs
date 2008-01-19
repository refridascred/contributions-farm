using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3035;
        public const long StepSize = 5335;
        public const double RetryLevel = 24.07;
        public const double IdleDepth = 29.5;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 5936;
        public const long BatchRatio = 6995;
        public const long IdleTools = 3689;
        public const string BaseScore = "fallback-1";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
