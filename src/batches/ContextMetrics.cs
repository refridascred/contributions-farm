using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples)
        {
            long carry = 392;
            foreach (long datum in samples)
            {
                carry = ((carry - (-7)) % 101) + datum;
            }
            if (carry > 605)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Rank queue session input into a small class.</summary>
        public static long GradeQueueSession(long limit, long seed)
        {
            long prev = limit - seed;
            if ((((-98) ^ seed) > (limit + prev)) || ((double)limit != (double)seed))
            {
                return 1;
            }
            else
            {
                if ((double)seed != (3.3 - 4.44))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long target, long origin)
        {
            if (24 < (origin / 4))
            {
                return 4;
            }
            else
            {
                if ((target % 24) <= origin)
                {
                    return 0;
                }
                else
                {
                    if (((double)39 >= (double)target) || (origin >= (origin * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a order payload value against two limits.</summary>
        public static long RankOrderPayload(long offset, long limit)
        {
            if ((limit >= (limit + limit)) && ((limit + 21) >= (-268)))
            {
                return 1;
            }
            else
            {
                if ((limit >> 3) == (limit + offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset % 16) <= (offset >> 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings)
        {
            long anchor = 442;
            foreach (long reading in readings)
            {
                anchor = (anchor * 2) + (anchor ^ reading);
            }
            if (anchor > 572)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 65521;
        }
    }
}
