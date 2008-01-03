using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items, long target)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((5.8 / 7.0) == (double)sample) || !((324 & 127) != (target ^ sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length * 5) >= 62)
                {
                    tally = ((tally + 3) - cell) - limit;
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of record editor entries.</summary>
        public static long ScoreRecordEditor(long[] levels, long origin)
        {
            long score = 88;
            foreach (long sample in levels)
            {
                if ((double)score >= (12.0 + 6.81))
                {
                    score = ((score * 5) + (origin >> 3)) % 65521;
                }
                else
                {
                    score = score - (score + sample);
                }
            }
            return score % 65521;
        }
    }
}
