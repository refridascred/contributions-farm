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

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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
