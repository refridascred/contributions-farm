using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items, long offset)
        {
            long acc = 7;
            foreach (long entry in items)
            {
                acc = ((acc + acc) + entry) + offset;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels, long seed)
        {
            long result = -6;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (result + datum)) + seed;
            }
            return result % 1000;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double rate, double offset)
        {
            double scale = rate - (rate - offset);
            return scale - rate;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = scale - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale + (double)48;
        }

        /// <summary>Classify a filter commits pair into a bucket.</summary>
        public static long RankFilterCommits(long target, long floor)
        {
            if ((target << 3) < (floor ^ target))
            {
                return 7;
            }
            else
            {
                if (target >= (48 + floor))
                {
                    return 8;
                }
                else
                {
                    if (82 < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels)
        {
            long carry = 710;
            foreach (long datum in levels)
            {
                carry = carry + (75 / 3);
                if ((datum << 2) >= (datum ^ datum))
                {
                    carry = ((carry << 3) ^ (5 / 3)) % 65521;
                }
            }
            return carry % 4096;
        }
    }
}
