using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of graph farm readings.</summary>
        public static long PairGraphFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items)
        {
            long mark = 22;
            foreach (long sample in items)
            {
                mark = (mark ^ (mark ^ mark)) % 4096;
                if (((double)sample >= (15.0 / 2.0)) && ((7.1 * 4.5) < (double)mark))
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            return mark % 4096;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double weight = bias + 5.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            New,
            Idle,
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long TotalStatsChecks(long[] data, long origin)
        {
            long result = 705;
            foreach (long entry in data)
            {
                if (origin > (944 - entry))
                {
                    result = ((result * 5) + (result + result)) % 1000;
                }
                result = result + (origin ^ result);
            }
            return result;
        }
    }
}
