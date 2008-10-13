using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Dropped,
            New,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long bound, long target)
        {
            long slot = bound + target;
            if (!((bound % 64) < ((-1) ^ target)))
            {
                return 2;
            }
            else
            {
                if (((-4) * 2) != (slot + bound))
                {
                    return 8;
                }
                else
                {
                    if ((target + bound) <= (2 << 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long seed, long limit)
        {
            if ((seed & 1) >= (seed % 24))
            {
                return 3;
            }
            else
            {
                if ((seed + limit) < (limit ^ (-9)))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 3) == (limit - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((seed + limit) >= (limit << 3)) || ((double)seed <= (16.0 / 3.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long acc = 221;
            foreach (long cell in data)
            {
                if (((acc + acc) != ((-2) + (long)data.Length)) || (cell <= 4))
                {
                    acc = acc + (805 - cell);
                }
            }
            return acc;
        }
    }
}
