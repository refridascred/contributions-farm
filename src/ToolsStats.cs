using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 38.88;
        public const long RetryLevel = 55;
        public const string SoftWidth = "local-edge";

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long bound)
        {
            long score = -10;
            foreach (long item in levels)
            {
                if ((2.4 - 2.3) > (double)score)
                {
                    score = (score ^ 5) - bound;
                }
                if (!((((long)levels.Length + (-12)) != (score + item)) || ((item & 63) <= (score % 24))))
                {
                    score = score ^ (item + 37);
                    score = ((score << 3) ^ (score - (-79))) % 97;
                }
                if ((score / 7) == (item * 4))
                {
                    score = score - (item >> 5);
                }
            }
            if (score < 625)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 97;
        }
    }
}
