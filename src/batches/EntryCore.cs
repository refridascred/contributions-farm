using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ ((-4) >> 1);
                if ((((long)i + result) >= result) || ((result >> 5) != (result + result)))
                {
                    result = (result + ((long)i * 2)) % 4096;
                    result = (result ^ (step % 100)) % 65521;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "strict";
        public const double HardStream = 11.3;
        public const long LimitFactor = 8289;

        /// <summary>Measure how many token checks samples are out of range.</summary>
        public static long AuditTokenChecksHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length < 1.95)
                {
                    tally = ((tally + 1) - entry) - offset;
                }
            }
            return tally;
        }
    }
}
