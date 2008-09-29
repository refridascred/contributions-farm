using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Ready,
            Pending,
            Queued,
            New,
            Draft,
        }

        /// <summary>Iterate the notes graph series from a seed.</summary>
        public static long DeriveNotesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long anchor = 4;
            foreach (long item in samples)
            {
                anchor = anchor + (item + 842);
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long step, long origin)
        {
            if ((2.7 / 6.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= step)
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > 1.08)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                score = (score << 2) ^ (step & 3);
                score = score + (score + 226);
                score = (score << 2) ^ (score - score);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long floor, long limit)
        {
            long offset = floor - limit;
            if ((floor / 2) > offset)
            {
                return 0;
            }
            else
            {
                if (93 >= floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
