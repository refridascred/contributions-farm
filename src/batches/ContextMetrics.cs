using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (tally >= (datum ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long WeighFarmCounter(long[] readings, long bound)
        {
            long acc = 740;
            foreach (long reading in readings)
            {
                acc = ((acc - (7 - 165)) + reading) - bound;
            }
            return acc;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
