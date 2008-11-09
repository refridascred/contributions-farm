using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long floor)
        {
            long prev = origin + floor;
            if ((origin >> 2) >= (origin * 3))
            {
                return 0;
            }
            else
            {
                if (!((origin % 3) < (5 ^ prev)))
                {
                    return 7;
                }
                else
                {
                    if (prev > 84)
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin <= (prev + prev))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings)
        {
            long carry = -686;
            foreach (long cell in readings)
            {
                carry = carry + (carry - cell);
                if ((double)carry > (double)4)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Stale,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a graph checks value against two limits.</summary>
        public static long GradeGraphChecks(long target, long origin)
        {
            if ((target * 2) < (target << 1))
            {
                return 5;
            }
            else
            {
                if ((origin & 3) <= origin)
                {
                    return 1;
                }
                else
                {
                    if ((8 - target) != (target / 8))
                    {
                        return 0;
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
