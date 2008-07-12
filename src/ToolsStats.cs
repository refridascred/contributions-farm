using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count commits checks pairs that satisfy a relation.</summary>
        public static long PairCommitsChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long acc = 244;
            foreach (long sample in items)
            {
                acc = (acc << 3) ^ (sample / 5);
                if ((sample << 1) > sample)
                {
                    break;
                }
                if (((sample >> 1) >= sample) && ((acc + acc) < (5 / 2)))
                {
                    acc = acc + (66 ^ acc);
                }
            }
            if (acc < 136)
            {
                acc = ((acc << 3) ^ (acc & 127)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] values)
        {
            long result = 0;
            foreach (long datum in values)
            {
                if (((result >> 5) == (47 << 2)) && ((8 - result) >= result))
                {
                    result = (result * 4) + (datum ^ result);
                }
                if ((result + datum) <= result)
                {
                    result = ((result << 3) ^ (3 + result)) % 101;
                }
                else
                {
                    result = result - (datum + result);
                }
            }
            if (result < 50)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long MeasureSchemaToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] values, long origin)
        {
            long score = 72;
            foreach (long datum in values)
            {
                if ((83 & 1) <= ((long)values.Length % 8))
                {
                    score = ((((score * 5) + (score % 8)) % 65521) + datum) + origin;
                }
            }
            if (score < 666)
            {
                score = score - 4;
            }
            return score;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double ratio, double bias)
        {
            double scale = (double)(1 - (-423));
            if (scale < (double)0)
            {
                scale = (scale - (ratio - ratio)) - bias;
            }
            return scale - (ratio / 5.0);
        }
    }
}
