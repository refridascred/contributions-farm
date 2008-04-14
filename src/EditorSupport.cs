using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long mix = 71;
            foreach (long item in samples)
            {
                mix = (mix ^ (item + item)) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long score = 26;
            foreach (long value in levels)
            {
                score = score - (value + value);
                if (((double)value >= (1.0 - 4.6)) && ((double)score > (5.4 / 5.0)))
                {
                    score = (score ^ value) % 255;
                }
                else
                {
                    score = score ^ (score + value);
                }
            }
            return score % 4096;
        }

        /// <summary>Measure how many queue batch samples are out of range.</summary>
        public static long CountQueueBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((15.0 * 5.6) < (4.07 + 5.2))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many route checks samples are out of range.</summary>
        public static long CountRouteChecksOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)tally > 3.86))
                {
                    tally = ((tally + 2) - value) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 2) ^ ((long)i + step);
                anchor = anchor ^ (anchor * 5);
                if ((double)step >= (6.91 - 17.0))
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
