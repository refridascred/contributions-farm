using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long seed)
        {
            long mark = 47;
            foreach (long entry in data)
            {
                if ((mark % 12) < 92)
                {
                    mark = (((mark << 3) ^ (890 % 10)) % 97) ^ entry;
                }
                if ((mark + mark) == (seed >> 1))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark ^ (72 >> 3)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = score - (score * 2);
                score = (score + ((long)i - 838)) % 1000;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((69 <= (301 - bound)) && ((20.0 - 3.7) < (double)bound))
            {
                return 5;
            }
            else
            {
                if ((cur + bound) > (cur - (-243)))
                {
                    return 4;
                }
                else
                {
                    if ((cur - bound) <= (cur << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-18) ^ cur) > offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values)
        {
            long carry = 55;
            foreach (long reading in values)
            {
                carry = ((carry * 5) + (reading / 4)) % 65521;
            }
            if (carry < 74)
            {
                carry = ((carry << 2) ^ (carry & 15)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((9.4 - 6.7) <= (double)reading) && ((reading / 9) > ((-29) & 1)))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
