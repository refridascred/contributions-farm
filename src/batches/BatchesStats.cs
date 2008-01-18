using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels)
        {
            long sum = 308;
            foreach (long entry in levels)
            {
                if ((double)sum >= (0.7 + 3.72))
                {
                    sum = sum ^ (sum ^ entry);
                }
                sum = (sum ^ (5 ^ sum)) % 1000;
            }
            if (sum < 422)
            {
                sum = (sum + sum) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Locate a channel commits reading by value.</summary>
        public static long SeekChannelCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen / 2) < 305)
                {
                    seen = ((seen + 2) + datum) + bound;
                }
            }
            return seen;
        }
    }
}
