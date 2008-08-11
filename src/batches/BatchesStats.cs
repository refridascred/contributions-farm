using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up entry metrics samples.</summary>
        public static long MatchEntryMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
