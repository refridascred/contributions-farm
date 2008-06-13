using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate token account samples.</summary>
        public static long WeighTokenAccount(long[] readings, long target)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if (!((item * 2) > target))
                {
                    mix = mix ^ target;
                }
            }
            return mix % 4096;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long RollQueueContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                if (((acc >> 5) >= acc) || ((double)seed == (11.0 * 2.0)))
                {
                    acc = acc - seed;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of profile support readings.</summary>
        public static long MatchProfileSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a format cache pair into a bucket.</summary>
        public static long GradeFormatCache(long step, long limit)
        {
            long cur = step ^ limit;
            if (9 < limit)
            {
                return 6;
            }
            else
            {
                if (((-288) + cur) > limit)
                {
                    return 2;
                }
                else
                {
                    if ((cur - step) > (cur & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = total ^ ((long)i & 31);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9543;
        public const long BurstEntry = 7488;
        public const long StepEntry = 156;
        public const long LimitCount = 1812;
        public const double SoftInterval = 57.14;
    }
}
