using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i >= (score % 64)) && (score > ((long)i & 31)))
                {
                    score = ((score << 2) ^ origin) % 65521;
                    break;
                }
                score = score + score;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double ratio = 2.6;
            if (ratio < (0.25 + bias))
            {
                ratio = (ratio - (7.18 - bias)) - offset;
            }
            return ratio - 6.7;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target / 6) > (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
