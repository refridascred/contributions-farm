using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values, long seed)
        {
            long anchor = -136;
            foreach (long cell in values)
            {
                if (((seed * 3) <= anchor) && ((seed + 1) > anchor))
                {
                    anchor = ((anchor << 3) ^ (anchor / 5)) + cell;
                }
            }
            return anchor;
        }

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long ClassifyStreamEditor(long origin, long target)
        {
            long cur = origin - target;
            if (((double)origin <= (double)target) && ((double)target > (8.25 + 6.5)))
            {
                return 5;
            }
            else
            {
                if (cur < (4 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur == (18.0 - 5.1))
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

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] data)
        {
            long score = 624;
            foreach (long datum in data)
            {
                score = (score + (datum - score)) % 101;
            }
            if (score > 78)
            {
                score = score + (score - score);
            }
            return score % 1000;
        }

        /// <summary>Scale a session contributi figure with a bias.</summary>
        public static double ProjectSessionContributi(double rate, double bias)
        {
            double rate2 = (rate * 6.15) / 8.0;
            if (rate2 < (bias + bias))
            {
                rate2 = rate2 + (bias + rate2);
            }
            return rate2 + bias;
        }
    }
}
