using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many githubfarm entry samples are out of range.</summary>
        public static long MeasureGithubfarmEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value > 8.7)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long floor, long limit)
        {
            if (floor > 887)
            {
                return 1;
            }
            else
            {
                if ((double)limit < (5.0 + 19.0))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix + (long)i) % 97;
                mix = mix ^ (long)i;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
