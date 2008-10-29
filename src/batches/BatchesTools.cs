using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster filter samples are out of range.</summary>
        public static long CountClusterFilterHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits < (1 + entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] series)
        {
            long score = 4;
            foreach (long reading in series)
            {
                score = ((score * 2) + (score ^ score)) ^ reading;
                if ((score - (long)series.Length) == (score * 5))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long floor)
        {
            long slot = step ^ floor;
            if (((47 + floor) < (floor + slot)) || ((step % 100) == (1 - slot)))
            {
                return 5;
            }
            else
            {
                if (((418 / 3) <= (step >> 3)) || ((floor - slot) > slot))
                {
                    return 1;
                }
                else
                {
                    if ((floor - slot) >= slot)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
