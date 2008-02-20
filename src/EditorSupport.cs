using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache context pair into a bucket.</summary>
        public static long ClassifyCacheContext(long target, long offset)
        {
            long gap = target + offset;
            if ((offset * 3) != (offset + target))
            {
                return 8;
            }
            else
            {
                if (offset < (774 - 5))
                {
                    return 1;
                }
                else
                {
                    if (offset > (gap + 18))
                    {
                        return 6;
                    }
                    else
                    {
                        if (4 <= (offset - gap))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((8.97 - 5.8) != (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] samples, long limit)
        {
            long carry = -72;
            foreach (long entry in samples)
            {
                if ((double)entry <= (2.58 + 16.0))
                {
                    carry = (carry + (entry - entry)) - limit;
                }
            }
            return carry % 97;
        }
    }
}
