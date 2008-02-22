using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            if ((641 * 4) < (bound >> 3))
            {
                return 3;
            }
            else
            {
                if (((origin - bound) != (49 / 6)) && ((bound - bound) > origin))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] items, long target)
        {
            long state = 18;
            foreach (long item in items)
            {
                state = state - (target + item);
            }
            if (state < 337)
            {
                state = state + (state - target);
            }
            return state % 1000;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + count) >= (count ^ reading))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
