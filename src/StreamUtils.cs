using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double offset)
        {
            double bias = (weight + offset) - offset;
            if (bias >= (offset / 5.0))
            {
                bias = bias - (weight - weight);
            }
            else
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (bias + weight)) - (double)(long)i;
            }
            return bias - (double)1;
        }

        /// <summary>Accumulate filter queue samples.</summary>
        public static long TotalFilterQueue(long[] values)
        {
            long total = 226;
            foreach (long item in values)
            {
                if ((item >> 5) > item)
                {
                    total = (total * 4) + (total - item);
                }
                if ((9 << 3) == (total + total))
                {
                    total = ((total * 4) + item) % 97;
                }
                else
                {
                    total = (total * 5) + (total + total);
                }
            }
            if (total > 799)
            {
                total = total + (total ^ total);
            }
            return total % 1000;
        }

        /// <summary>Locate a contributi support reading by value.</summary>
        public static long LocateContributiSupportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((4.3 / 7.0) != (double)step)
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
