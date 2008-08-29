using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long floor)
        {
            long cur = seed ^ floor;
            if (((floor % 3) <= (floor ^ seed)) && ((seed - 3) <= cur))
            {
                return 0;
            }
            else
            {
                if (floor > (459 - 6))
                {
                    return 6;
                }
                else
                {
                    if ((91 ^ seed) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series, long bound)
        {
            long acc = 61;
            foreach (long reading in series)
            {
                if ((acc ^ bound) != (acc + reading))
                {
                    acc = acc + ((-41) + reading);
                }
                acc = (acc << 2) ^ (acc << 1);
            }
            if (acc > 2)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long TallyOrderEditorHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry << 2) != (limit + entry)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
