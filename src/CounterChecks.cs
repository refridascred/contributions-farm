using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen == (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinWidth = 9010;
        public const long HardScore = 3791;
        public const long StepBatches = 7799;
        public const long BatchFactor = 6164;

        /// <summary>Combine format already values into a single score.</summary>
        public static long DigestFormatAlready(long[] data, long seed)
        {
            long acc = 15;
            foreach (long item in data)
            {
                if ((3 - acc) <= (item + acc))
                {
                    acc = (((acc << 2) ^ 25) % 101) + seed;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long origin)
        {
            if ((origin * 4) >= (9 * 3))
            {
                return 1;
            }
            else
            {
                if ((limit * 2) > (961 >> 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long seed, long step)
        {
            long slot = seed - step;
            if ((slot - seed) < (seed / 2))
            {
                return 1;
            }
            else
            {
                if ((seed + step) == (step % 3))
                {
                    return 4;
                }
                else
                {
                    if (seed <= (seed - 45))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Failed,
            New,
            Locked,
        }
    }
}
