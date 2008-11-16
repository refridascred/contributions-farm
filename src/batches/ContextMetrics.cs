using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long SeekGithubfarmSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a stream cache value against two limits.</summary>
        public static long GradeStreamCache(long limit, long step)
        {
            long gap = limit - step;
            if ((gap >> 5) == (limit - gap))
            {
                return 1;
            }
            else
            {
                if ((0.5 / 2.0) >= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((step - gap) < step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((766 << 3) > (step + step)) && ((limit % 8) < (gap - limit)))
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
        }

        /// <summary>Measure how many tools notes samples are out of range.</summary>
        public static long CountToolsNotesHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item + item) == (hits ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] values)
        {
            long carry = 87;
            foreach (long entry in values)
            {
                if ((3.8 > (double)entry) || (carry > (carry + entry)))
                {
                    carry = ((carry << 3) ^ (2 - 28)) % 97;
                }
                if (!((77 - carry) <= (4 * 3)))
                {
                    carry = ((carry * 5) + (carry ^ entry)) % 1000;
                }
                carry = (carry - (56 + carry)) % 97;
            }
            return carry % 97;
        }
    }
}
