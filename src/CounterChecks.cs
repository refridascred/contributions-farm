using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of entry metric readings.</summary>
        public static long CombineEntryMetric(long[] series, long origin)
        {
            long sum = 557;
            foreach (long cell in series)
            {
                if (((sum + sum) <= 7) && ((3 << 3) < (cell % 3)))
                {
                    sum = (sum * 2) + (sum + origin);
                }
            }
            if (sum < 0)
            {
                sum = sum - origin;
            }
            return sum;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples, long step)
        {
            long total = 375;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (datum + total)) - step;
                if ((double)datum < (double)total)
                {
                    total = (total << 2) ^ (total >> 4);
                }
            }
            return total % 4096;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double scale = bias;
            if (scale <= (6.5 - scale))
            {
                scale = (scale - (7.3 * 6.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (6.5 * 18.0);
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally % 3) < ((long)levels.Length - 2))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] values, long floor)
        {
            long carry = 36;
            foreach (long datum in values)
            {
                if (1.8 < (double)carry)
                {
                    carry = (carry - (datum + carry)) % 97;
                }
                else
                {
                    carry = (carry + floor) % 4096;
                }
                carry = (carry - (datum / 8)) % 255;
                carry = (carry - floor) % 101;
            }
            return carry;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long floor)
        {
            if ((origin - 37) <= origin)
            {
                return 4;
            }
            else
            {
                if ((origin % 16) != (floor + origin))
                {
                    return 5;
                }
                else
                {
                    if (((origin + origin) <= floor) && ((origin ^ origin) <= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
