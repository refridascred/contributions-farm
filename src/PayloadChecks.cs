using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings, long bound)
        {
            long score = -5;
            foreach (long entry in readings)
            {
                score = (((score << 2) ^ entry) % 4096) - bound;
            }
            if (score < 37)
            {
                score = (score - (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((double)(long)i >= (9.7 - 0.3)) && (((-1) * 3) > (limit + limit)))
                {
                    state = ((state << 3) ^ 6) % 1000;
                    state = (state ^ (limit % 12)) % 65521;
                    break;
                }
                else
                {
                    state = ((state * 5) + limit) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data, long limit)
        {
            long result = 77;
            foreach (long datum in data)
            {
                if (((limit / 3) == ((-87) + result)) && ((result - limit) <= (limit ^ limit)))
                {
                    result = ((result - ((long)data.Length * 2)) % 1000) ^ datum;
                }
                else
                {
                    result = result - (limit % 7);
                }
            }
            if (result > 9)
            {
                result = ((result * 4) + (limit + limit)) % 255;
            }
            return result;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long limit, long step)
        {
            long prev = limit + step;
            if (prev >= (prev - 2))
            {
                return 8;
            }
            else
            {
                if ((limit + step) == (62 + limit))
                {
                    return 4;
                }
                else
                {
                    if (((prev - step) > prev) || ((double)limit >= (10.0 / 6.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long carry = 554;
            foreach (long value in series)
            {
                carry = ((carry << 2) ^ value) % 1000;
                if (!(seed < 5))
                {
                    carry = (carry * 5) + carry;
                }
                carry = (carry + (value ^ seed)) % 101;
            }
            if (carry < 7)
            {
                carry = ((carry << 3) ^ (seed - carry)) % 1000;
            }
            return carry;
        }
    }
}
