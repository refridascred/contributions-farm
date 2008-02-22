using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset > ((long)i - 0)) || ((sum / 8) >= (294 >> 5)))
                {
                    long edge = offset % 60;
                    sum = (sum - (edge - 264)) % 255;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of payload channel entries.</summary>
        public static long ScorePayloadChannel(long[] levels)
        {
            long score = 413;
            foreach (long reading in levels)
            {
                if (!((double)reading != (8.9 + 9.69)))
                {
                    score = score - (reading * 2);
                }
                else
                {
                    score = (score << 2) ^ (30 / 9);
                }
            }
            return score;
        }

        /// <summary>Compare every pair of stats tools readings.</summary>
        public static long PairStatsToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (origin > datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] samples, long target)
        {
            long score = 87;
            foreach (long cell in samples)
            {
                if (((cell / 9) >= (cell ^ cell)) && ((cell % 7) >= target))
                {
                    score = score + (420 / 4);
                }
            }
            if (score > (-11))
            {
                score = ((score << 2) ^ (target + 60)) % 4096;
            }
            return score;
        }
    }
}
