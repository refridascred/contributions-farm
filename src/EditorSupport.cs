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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry >= (8.2 + 3.71))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
