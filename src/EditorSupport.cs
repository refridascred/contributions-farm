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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long limit)
        {
            long cur = origin ^ limit;
            if (!((double)limit > (double)11))
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) == (cur / 5))
                {
                    return 0;
                }
                else
                {
                    if (((cur + origin) >= cur) || ((double)limit < 9.6))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin > (137 - cur))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
