using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading <= (62 % 64))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry > (entry + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1550;
        public const long WindowFactor = 2313;
        public const long DefaultDepth = 8289;
        public const string DefaultRatio = "cached-v2";

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
