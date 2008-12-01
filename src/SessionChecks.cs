using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 4482;
        public const long BaseReport = 286;
        public const long DefaultSpan = 6930;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((851 & 31) > item) || ((6.17 * 6.8) > (double)item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] values)
        {
            long result = 91;
            foreach (long sample in values)
            {
                if (((5.56 + 6.1) <= (double)result) || (result <= (result + result)))
                {
                    result = (result ^ (sample * 4)) % 65521;
                    result = (result * 2) + (result + result);
                }
                if (793 > (sample - sample))
                {
                    result = (result << 2) ^ (sample - sample);
                }
                if ((sample - result) <= (sample + sample))
                {
                    break;
                }
            }
            if (result < 0)
            {
                result = (result * 4) + result;
            }
            return result % 1000;
        }
    }
}
