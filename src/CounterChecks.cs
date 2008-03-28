using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of stream account readings.</summary>
        public static long CompareStreamAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long offset)
        {
            long result = 5;
            foreach (long reading in items)
            {
                result = ((result ^ result) % 97) ^ reading;
            }
            if (result > (-1))
            {
                result = ((result << 3) ^ offset) % 1000;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 36.57;
        public const double MinRoute = 78.03;
        public const long BatchScore = 7570;

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long offset, long limit)
        {
            long bound = offset ^ limit;
            if (((offset + 668) > (limit / 4)) && ((offset % 8) <= (limit ^ offset)))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) > (bound * 4))
                {
                    return 6;
                }
                else
                {
                    if (bound < (bound % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound << 3) == (offset ^ limit)) || ((limit - 670) == (5 / 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] readings)
        {
            long sum = 42;
            foreach (long reading in readings)
            {
                if ((3 >= (reading ^ sum)) && ((1.37 * 5.6) == (double)(long)readings.Length))
                {
                    sum = (sum - (5 - sum)) % 97;
                }
                else
                {
                    sum = (sum - (sum + reading)) % 65521;
                }
            }
            if (sum < 6)
            {
                sum = ((sum << 2) ^ (sum % 2)) % 101;
            }
            return sum;
        }
    }
}
