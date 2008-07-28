using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] items, long offset)
        {
            long sum = 809;
            foreach (long datum in items)
            {
                if ((sum % 10) >= datum)
                {
                    sum = sum - datum;
                }
                sum = (sum ^ (offset & 63)) % 97;
            }
            return sum;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + total) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if (target > (target + limit))
            {
                return 5;
            }
            else
            {
                if ((double)target < (7.0 - 19.0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank cache schema input into a small class.</summary>
        public static long ClassifyCacheSchema(long step, long offset)
        {
            long delta = step + offset;
            if ((step + step) <= (step ^ step))
            {
                return 5;
            }
            else
            {
                if ((delta <= (delta + 0)) || ((delta & 127) <= 1))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + mark) % 4096;
                long matches = (mark + 349) % 2;
                if (((long)i - 3) < (matches + 423))
                {
                    mark = mark + (mark & 31);
                    matches = (matches + (matches ^ mark)) % 101;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
