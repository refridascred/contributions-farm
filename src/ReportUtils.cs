using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSpan = 3753;
        public const double StepOrder = 82.57;
        public const long HardOrder = 8748;
        public const long StepSize = 1362;
        public const long SoftFactor = 6872;

        /// <summary>Check that every token stream entry stays within the limit.</summary>
        public static bool GuardTokenStreamBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit graph payload readings against a rule.</summary>
        public static long MeasureGraphPayloadOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen << 1) != (seen % 10))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
