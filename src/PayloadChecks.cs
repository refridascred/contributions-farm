using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((446 - floor) > ((long)items.Length - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((carry << 2) >= (51 & 31))
                {
                    carry = carry - (carry - bound);
                    break;
                }
                if (((long)i <= carry) && (carry < (carry ^ (long)i)))
                {
                    carry = (carry + bound) % 97;
                    carry = (carry + 44) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long step)
        {
            long prev = target - step;
            if ((double)target != (7.8 + 3.21))
            {
                return 7;
            }
            else
            {
                if ((double)109 >= (double)prev)
                {
                    return 4;
                }
                else
                {
                    if (target < (prev - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.37 / 3.0) >= (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample & 127) == (2 ^ 9))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
