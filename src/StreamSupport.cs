using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) < reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] samples)
        {
            long carry = 5;
            foreach (long reading in samples)
            {
                if (!((carry * 3) < carry))
                {
                    carry = ((carry ^ (1 << 1)) % 255) + reading;
                }
                else
                {
                    carry = carry - 8;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long RankCommitsEditor(long limit, long target)
        {
            if (((target & 7) > target) || ((96 - limit) >= (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 5) == (target & 127))
                {
                    return 4;
                }
                else
                {
                    if ((target / 6) > (limit / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-65) << 1) < (limit + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
