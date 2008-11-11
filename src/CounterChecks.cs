using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= (scale + ratio))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (offset - offset)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((bound2 <= (bound & 1)) || ((bound << 2) == (903 << 2)))
            {
                return 1;
            }
            else
            {
                if (floor >= (bound2 % 97))
                {
                    return 3;
                }
                else
                {
                    if (((29 - 33) < (478 - floor)) && (bound <= (bound - bound2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound2 / 2) <= bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items)
        {
            long sum = 39;
            foreach (long item in items)
            {
                if ((sum / 5) <= (sum / 8))
                {
                    sum = ((sum ^ sum) % 65521) + item;
                }
                if ((7.0 / 5.0) < (double)sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((939 ^ bound) < (origin - bound))
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)(-31))
                {
                    return 5;
                }
                else
                {
                    if ((origin + 67) <= (origin & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
