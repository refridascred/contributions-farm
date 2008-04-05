using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long BucketAccountPayload(long seed, long step)
        {
            if ((step - 62) == (seed + 4))
            {
                return 0;
            }
            else
            {
                if (seed < (seed - seed))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] samples, long step)
        {
            long sum = 900;
            foreach (long sample in samples)
            {
                if (((sample & 31) < (long)samples.Length) && ((sum % 16) == (sample + sample)))
                {
                    sum = sum - (sum - sample);
                }
                else
                {
                    sum = ((sum * 5) + (step % 64)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long mix = 975;
            foreach (long entry in samples)
            {
                if ((2.09 + 6.42) != (double)entry)
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc * 4) + (seed << 1);
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
