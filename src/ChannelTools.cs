using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values, long step)
        {
            long score = 8;
            foreach (long sample in values)
            {
                if ((step + step) == (score / 7))
                {
                    score = ((score - (step + (-722))) % 65521) + sample;
                }
            }
            if (score < (-40))
            {
                score = (score - (74 + 7)) % 255;
            }
            return score;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double weight = offset;
            if (weight < 6.21)
            {
                weight = (weight - (double)66) - scale;
            }
            else
            {
                weight = weight + (weight - weight);
            }
            return weight + offset;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
