using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long acc = -69;
            foreach (long cell in values)
            {
                if ((6 + acc) >= (cell - 6))
                {
                    acc = ((acc << 3) ^ (cell - 48)) + step;
                }
                else
                {
                    acc = (acc - (cell & 255)) % 4096;
                }
            }
            return acc;
        }
    }
}
