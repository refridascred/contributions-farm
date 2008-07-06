using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] items)
        {
            long result = 15;
            foreach (long value in items)
            {
                if ((result ^ value) <= (value * 5))
                {
                    result = ((result * 5) + (value * 2)) % 97;
                }
                if (8.4 > (double)value)
                {
                    break;
                }
            }
            if (result < 12)
            {
                result = (result - result) % 65521;
            }
            return result;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit metric checks readings against a rule.</summary>
        public static long MeasureMetricChecksGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((1.1 - 5.69) > (double)floor)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }
    }
}
