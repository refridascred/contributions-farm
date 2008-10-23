using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "fallback-edge";
        public const long MaxProfile = 9690;
        public const long StepProfile = 6232;
        public const long SoftWidth = 5774;
        public const long HardProfile = 5864;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 321;
        public const long HardTimeout = 6320;
        public const string HardFactor = "staging-v2";

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Closed,
            Active,
            Stale,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 83.87;
        public const long BaseRatio = 8148;
        public const string MinDepth = "alpha-edge";

        /// <summary>Fold a list of profile cluster readings.</summary>
        public static long FoldProfileCluster(long[] levels, long offset)
        {
            long mix = 960;
            foreach (long datum in levels)
            {
                if (datum > 541)
                {
                    mix = mix + (datum + offset);
                }
                else
                {
                    mix = ((mix << 2) ^ (offset + offset)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
