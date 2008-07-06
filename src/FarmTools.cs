using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload tools value against two limits.</summary>
        public static long ClassifyPayloadTools(long limit, long limit2)
        {
            if (limit > 5)
            {
                return 3;
            }
            else
            {
                if ((limit - limit) == (940 + limit))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
