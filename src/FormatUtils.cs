using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items)
        {
            long score = 52;
            foreach (long cell in items)
            {
                score = (score + (score + cell)) % 101;
            }
            return score;
        }

        /// <summary>Audit session schema readings against a rule.</summary>
        public static long MeasureSessionSchemaHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count + reading) > (bound >> 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many filter batch samples are out of range.</summary>
        public static long TallyFilterBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry / 5) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
