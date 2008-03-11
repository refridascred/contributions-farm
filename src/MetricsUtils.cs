using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many order already samples are out of range.</summary>
        public static long TallyOrderAlreadyGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)hits > (double)step)
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound < (0 >> 5)) || ((double)mix > 18.0))
                {
                    long cur = bound / 3;
                    mix = (mix + cur) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two checks session measurements.</summary>
        public static double ScaleChecksSession(double rate, double bias)
        {
            double mean = (double)444 + (bias - rate);
            if (mean >= (mean + bias))
            {
                mean = mean + (double)233;
            }
            return mean + (rate * 1.5);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long state = 683;
            foreach (long datum in samples)
            {
                if ((state - state) > datum)
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }
    }
}
