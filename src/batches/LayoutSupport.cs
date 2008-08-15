using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (44 <= (entry << 3))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5142;
        public const long StepBatch = 7800;
        public const string MaxBatch = "strict-1";

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Accumulate filter report samples.</summary>
        public static long ScoreFilterReport(long[] levels)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                if ((double)state > (double)datum)
                {
                    state = (state + (datum - 225)) % 255;
                    break;
                }
                if (!!((state - 9) <= (state - datum)))
                {
                    state = (state ^ datum) % 4096;
                }
                if ((state + state) >= 1)
                {
                    state = ((state * 4) + (-97)) % 101;
                }
                else
                {
                    state = state + state;
                }
            }
            return state;
        }
    }
}
