using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((double)reading < (3.0 / 6.0)) || (reading >= (reading / 9))) && (((-46) + 769) != (reading & 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 79.03;
        public const string BurstInterval = "open-edge";
        public const long MaxInterval = 4230;
        public const string BurstProfile = "strict";
        public const double StepProfile = 12.39;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long limit)
        {
            long score = 148;
            foreach (long reading in data)
            {
                if ((4.96 / 4.0) < (double)score)
                {
                    score = ((score * 3) + reading) - limit;
                }
            }
            return score % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((2.71 * 7.5) <= (double)tally)
                {
                    tally = ((tally + 3) ^ cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count notes metric pairs that satisfy a relation.</summary>
        public static long MatchNotesMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
