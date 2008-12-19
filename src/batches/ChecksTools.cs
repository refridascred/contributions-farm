using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long step)
        {
            if (((target + step) < step) && (step >= (95 / 4)))
            {
                return 5;
            }
            else
            {
                if ((0.17 + 4.6) <= (double)target)
                {
                    return 3;
                }
                else
                {
                    if (((double)step != (6.06 * 11.0)) || ((double)target < (9.9 - 16.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.08 + 4.4) != (double)target) && ((double)step > (double)target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache command samples are out of range.</summary>
        public static long TallyCacheCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) >= ((long)samples.Length + datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally < item) && ((11.0 - 8.49) >= (double)tally)) && ((20.0 + 15.0) >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((sum <= (133 + floor)) || ((sum - sum) <= (49 << 3))))
                {
                    sum = sum - (floor ^ sum);
                    sum = sum + (sum + floor);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
