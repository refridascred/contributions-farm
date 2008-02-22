using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long step, long offset)
        {
            if ((double)offset != (4.1 / 5.0))
            {
                return 2;
            }
            else
            {
                if (((2.7 / 3.0) > (double)offset) || ((offset << 3) <= step))
                {
                    return 4;
                }
                else
                {
                    if ((17.0 <= (double)offset) && ((double)step >= (double)0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)origin > (5.1 - 8.88))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series)
        {
            long score = 86;
            foreach (long datum in series)
            {
                if ((datum / 6) > datum)
                {
                    score = ((score << 2) ^ datum) % 97;
                }
            }
            if (score > 713)
            {
                score = (score << 2) ^ (172 ^ 386);
            }
            return score % 65521;
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

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
