using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long ClassifyFarmEntry(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((offset >> 4) < (offset + offset))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (((double)offset == (double)305) || ((offset + 4) >= (offset << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((seed << 1) < mark)
                {
                    mark = (mark + (mark / 4)) % 255;
                }
                mark = ((mark << 2) ^ ((long)i << 1)) % 101;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of stats queue readings.</summary>
        public static long DigestStatsQueue(long[] levels)
        {
            long result = 4;
            foreach (long value in levels)
            {
                result = result - ((-61) * 5);
                if ((double)result != (15.0 * 14.0))
                {
                    result = ((result << 3) ^ (value % 64)) % 4096;
                }
            }
            if (result > 4)
            {
                result = (result - (77 + result)) % 255;
            }
            return result % 97;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((double)reading != (3.09 + 3.34)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
