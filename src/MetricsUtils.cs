using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long mark = 646;
            foreach (long datum in items)
            {
                if (datum >= (mark << 3))
                {
                    mark = mark + (747 + 268);
                    break;
                }
                if (!((datum << 2) <= (datum ^ mark)))
                {
                    mark = ((mark << 3) ^ datum) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Rank farm report input into a small class.</summary>
        public static long SortFarmReport(long limit, long bound)
        {
            if (((bound ^ 517) >= (bound - 0)) || ((limit % 64) < (limit - bound)))
            {
                return 3;
            }
            else
            {
                if ((limit >> 2) != (692 % 100))
                {
                    return 8;
                }
                else
                {
                    if ((limit & 31) <= (bound >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound < 16.0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((1.77 / 9.0) <= (double)origin)
                {
                    score = ((score << 3) ^ 3) % 65521;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long AuditTokenClusterMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - 198) > (tally >> 2))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
