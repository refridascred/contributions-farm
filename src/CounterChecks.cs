using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a payload support reading by value.</summary>
        public static long FindPayloadSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Retry,
            Queued,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 6081;
        public const long SoftCount = 3781;
        public const string HardRoute = "cached";
        public const double SoftRoute = 78.81;
        public const string SoftScore = "legacy-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLevel = 4184;
        public const double BaseCount = 94.55;
        public const long RetrySize = 1942;
        public const long SoftFactor = 1740;
        public const long WindowLevel = 5505;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(431 <= value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
