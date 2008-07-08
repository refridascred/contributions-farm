using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a stats channel counter forward.</summary>
        public static long DeriveStatsChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((long)items.Length + reading) > (target + target)) && ((double)seen >= (16.0 - 8.35)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!!(5 > (carry << 3)))
                {
                    carry = carry - (25 + (long)i);
                }
                if ((carry % 3) <= 18)
                {
                    carry = (carry ^ ((long)i >> 4)) % 4096;
                    carry = (carry - bound) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a batches filter reading.</summary>
        public static double ProjectBatchesFilter(double weight, double span)
        {
            double ratio = weight * 20.0;
            if (ratio <= (ratio - 3.5))
            {
                ratio = (ratio + (double)41) - span;
            }
            return ratio + 6.91;
        }

        /// <summary>Rank contributi cluster input into a small class.</summary>
        public static long RankContributiCluster(long bound, long limit)
        {
            if ((double)bound != (5.0 * 1.82))
            {
                return 1;
            }
            else
            {
                if ((limit <= (limit * 5)) && ((double)limit != (4.9 * 3.9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + bound) > (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (18.0 >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Retry,
            Pending,
            Active,
            Synced,
            Ready,
        }
    }
}
