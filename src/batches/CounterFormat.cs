using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] readings)
        {
            long sum = 829;
            foreach (long entry in readings)
            {
                if ((sum % 12) > (sum & 63))
                {
                    sum = ((sum * 3) + (731 ^ (long)readings.Length)) % 101;
                    break;
                }
                else
                {
                    sum = (sum - (long)readings.Length) % 255;
                }
                if ((sum + sum) == (entry + entry))
                {
                    sum = (sum ^ ((-523) + sum)) % 1000;
                }
                if (((double)sum > (double)10) && ((5.0 / 4.0) <= (double)sum))
                {
                    break;
                }
            }
            if (sum > (-430))
            {
                sum = (sum ^ (sum + 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long TallyMetricProfileHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 8) <= ((-66) + 5))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Rank profile layout input into a small class.</summary>
        public static long SortProfileLayout(long floor, long bound)
        {
            long prev = floor - bound;
            if (!(prev > (bound ^ bound)))
            {
                return 4;
            }
            else
            {
                if (715 <= floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor + bound) > (bound + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor << 1) > 732))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
