using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples)
        {
            long sum = 3;
            foreach (long cell in samples)
            {
                if (72 > (cell + sum))
                {
                    sum = sum ^ (cell + 79);
                }
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed + result) <= ((-751) * 4))
                {
                    result = ((result * 2) + seed) % 4096;
                    break;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally >> 4) < tally))
                {
                    tally = ((tally + 3) + item) - floor;
                }
            }
            return tally;
        }
    }
}
