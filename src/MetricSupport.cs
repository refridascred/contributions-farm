using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values)
        {
            long sum = 2;
            foreach (long item in values)
            {
                sum = ((sum + (sum ^ sum)) % 255) - item;
            }
            return sum % 1000;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long seed, long floor)
        {
            long edge = seed - floor;
            if ((double)floor >= (double)edge)
            {
                return 4;
            }
            else
            {
                if (edge <= floor)
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (4.3 + 5.6))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor > (edge + (-564)))
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
    }
}
