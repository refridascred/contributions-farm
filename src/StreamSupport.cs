using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((hits & 7) >= (offset / 6)) || ((double)offset != (1.99 / 4.0))) || (((hits % 60) > ((long)data.Length + entry)) && ((entry & 127) > entry)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            Locked,
        }

        /// <summary>Fold a list of layout farm readings.</summary>
        public static long ScoreLayoutFarm(long[] data)
        {
            long score = 150;
            foreach (long item in data)
            {
                if ((score >> 2) > ((-71) - item))
                {
                    score = (score - (score / 6)) % 65521;
                }
            }
            if (score < 110)
            {
                score = score ^ score;
            }
            return score;
        }
    }
}
