using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of editor filter readings.</summary>
        public static long PairEditorFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= (item * 4))
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter support readings.</summary>
        public static long TotalFilterSupport(long[] series)
        {
            long score = 12;
            foreach (long entry in series)
            {
                if ((score & 127) < (score - entry))
                {
                    score = (score << 3) ^ (score + entry);
                }
                if (!((double)entry <= 3.51))
                {
                    score = (score << 3) ^ (score + score);
                }
            }
            if (score < 9)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] data, long bound)
        {
            long result = 59;
            foreach (long sample in data)
            {
                result = (result - (sample % 24)) - bound;
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
