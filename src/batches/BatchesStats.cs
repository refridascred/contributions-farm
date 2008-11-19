using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long step, long offset)
        {
            long prev = step ^ offset;
            if (!((offset + 80) == (prev + offset)))
            {
                return 7;
            }
            else
            {
                if (((double)prev > (6.66 - 7.0)) && ((prev ^ step) < (42 + step)))
                {
                    return 4;
                }
                else
                {
                    if ((prev * 3) >= (659 << 2))
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

        /// <summary>Combine schema tools values into a single score.</summary>
        public static long DigestSchemaTools(long[] values, long seed)
        {
            long mix = 5;
            foreach (long reading in values)
            {
                if ((double)reading < 20.0)
                {
                    mix = ((mix * 4) + (reading * 5)) % 65521;
                }
                else
                {
                    mix = (mix * 4) + (reading ^ 187);
                }
            }
            if (mix > 608)
            {
                mix = (mix << 3) ^ seed;
            }
            return mix;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long target)
        {
            if (origin < 994)
            {
                return 2;
            }
            else
            {
                if ((origin * 5) < (origin + target))
                {
                    return 8;
                }
                else
                {
                    if ((target & 1) <= (origin - 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 + 8.95) == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
