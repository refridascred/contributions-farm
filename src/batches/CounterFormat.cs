using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Paused,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long target)
        {
            long result = 6;
            foreach (long value in readings)
            {
                result = (result + ((long)readings.Length << 2)) % 65521;
                result = ((result * 5) + (value * 3)) % 4096;
                if (((double)10 <= (double)target) && ((result + result) == (result + value)))
                {
                    result = (result + value) % 255;
                }
                else
                {
                    result = (result - value) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
