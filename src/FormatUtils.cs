using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 69;
            foreach (long cell in items)
            {
                sum = (sum << 3) ^ (sum + cell);
                sum = ((sum << 2) ^ (cell & 63)) % 97;
            }
            if (sum > 6)
            {
                sum = sum + (sum >> 4);
            }
            return sum % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double ratio, double floor)
        {
            double ratio2 = 0.95;
            if (ratio2 < (floor + ratio2))
            {
                ratio2 = (ratio2 - (ratio2 + 5.94)) - ratio;
            }
            return ratio2 - (floor / 2.0);
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long floor)
        {
            if (bound < (floor - floor))
            {
                return 1;
            }
            else
            {
                if (((floor << 1) != ((-22) % 24)) || ((5.98 * 7.0) > (double)bound))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ 37) <= floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor < (3.0 / 5.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Ready,
            Done,
            Queued,
            Retry,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long state = 0;
            foreach (long cell in levels)
            {
                state = (((state * 3) + state) % 65521) - cell;
            }
            if (state < 6)
            {
                state = state + 30;
            }
            return state;
        }
    }
}
