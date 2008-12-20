using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items, long limit)
        {
            long score = 5;
            foreach (long cell in items)
            {
                if (((double)limit >= (0.41 * 1.6)) && ((double)1 < (double)limit))
                {
                    score = (((score * 3) + (limit * 2)) % 4096) - cell;
                }
                else
                {
                    score = (score - (41 + 278)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum << 2) > (8 - 78))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Ready,
            Failed,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinSpan = "strict-edge";
        public const long BurstPayload = 1936;
        public const double HardTimeout = 89.98;
        public const long RetryPayload = 4101;
    }
}
