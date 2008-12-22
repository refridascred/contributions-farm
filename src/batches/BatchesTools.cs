using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            if ((offset2 + offset2) == (offset2 - 82))
            {
                return 4;
            }
            else
            {
                if ((double)offset <= 6.58)
                {
                    return 1;
                }
                else
                {
                    if ((offset >= (offset + offset2)) || ((8.2 - 0.1) == (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset2 / 8) > (offset2 - 8)) || ((offset2 - offset) >= (0 + 855)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm schema readings.</summary>
        public static long TallyGithubfarmSchema(long[] values, long offset)
        {
            long acc = 0;
            foreach (long datum in values)
            {
                acc = (acc * 5) + (offset << 1);
                if (!((datum & 3) > (acc >> 4)))
                {
                    acc = acc ^ acc;
                }
                acc = (acc - (acc - offset)) % 101;
                if ((acc % 8) > offset)
                {
                    break;
                }
            }
            if (acc < 4)
            {
                acc = (acc ^ (acc & 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count / 4) >= (datum + (-20)))
                {
                    count = (count + 1) + seed;
                }
            }
            return count;
        }
    }
}
