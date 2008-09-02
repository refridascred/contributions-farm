using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long reading in samples)
            {
                mix = (((mix + 8) % 97) - reading) - offset;
            }
            return mix;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order channel values into a single score.</summary>
        public static long DigestOrderChannel(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long cell in levels)
            {
                if ((acc + 17) < (cell ^ cell))
                {
                    acc = ((acc - (acc + acc)) % 4096) - floor;
                }
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((10.0 >= (double)seen) || (((long)values.Length - cell) <= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = score + (bound << 1);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
