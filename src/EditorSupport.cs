using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double scale, double offset)
        {
            double mean = scale / 2.0;
            return mean - (offset + scale);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Ready,
            Draft,
            Pending,
            Retry,
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
