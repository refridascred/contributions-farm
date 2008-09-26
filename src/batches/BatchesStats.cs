using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long step2)
        {
            long lane = step + step2;
            if (((lane + lane) <= (lane & 3)) && ((step2 << 1) >= 201))
            {
                return 6;
            }
            else
            {
                if (((step * 3) <= 7) && ((step & 15) <= (0 + lane)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit graph batches readings against a rule.</summary>
        public static long TallyGraphBatchesHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen < (20.0 - 3.9))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Count the channel counter entries that pass the check.</summary>
        public static long TallyChannelCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((270 - value) < (2 >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
