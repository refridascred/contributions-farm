using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "local-1";
        public const long RetryEntry = 6075;
        public const long CacheLevel = 8565;
        public const double LimitTimeout = 13.39;
        public const double BatchEntry = 98.71;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long limit)
        {
            long offset = bound - limit;
            if (bound > (bound << 2))
            {
                return 3;
            }
            else
            {
                if (limit < (bound - 566))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 10) <= offset) && (offset <= ((-658) ^ bound)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((offset >> 3) <= ((-16) ^ bound)) || ((offset & 7) >= bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
