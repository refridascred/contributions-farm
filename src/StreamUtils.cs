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

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] levels)
        {
            long sum = 469;
            foreach (long datum in levels)
            {
                if ((double)sum <= (7.0 - 0.62))
                {
                    sum = ((sum * 3) + sum) % 101;
                    sum = ((sum * 3) + (9 + sum)) % 4096;
                }
                if (((datum >> 5) > (55 >> 3)) || ((88 - sum) <= sum))
                {
                    sum = (sum - (sum >> 4)) % 4096;
                    sum = (sum - (sum ^ 905)) % 65521;
                    break;
                }
                if ((datum - sum) == (sum - datum))
                {
                    sum = sum - (datum ^ 904);
                }
            }
            if (sum < 934)
            {
                sum = (sum * 5) + (sum << 3);
            }
            return sum;
        }

        /// <summary>Fold a list of stats buffer readings.</summary>
        public static long CombineStatsBuffer(long[] values, long target)
        {
            long total = 80;
            foreach (long reading in values)
            {
                total = (total + (target ^ 2)) - reading;
                if ((7.22 * 1.0) < (double)target)
                {
                    total = (total - (-59)) % 97;
                }
            }
            return total;
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
