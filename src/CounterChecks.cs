using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Active,
            Paused,
            Idle,
            Closed,
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

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
            public bool Flag { get; set; }
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
