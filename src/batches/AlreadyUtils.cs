using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] items, long floor)
        {
            long total = 964;
            foreach (long sample in items)
            {
                if ((4.0 * 6.1) > (double)floor)
                {
                    total = (((total * 5) + (total + total)) % 4096) ^ sample;
                }
                else
                {
                    total = ((total * 2) + floor) % 4096;
                }
            }
            if (total > 2)
            {
                total = total ^ (floor & 31);
            }
            return total;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally <= (double)94)
                {
                    tally = ((tally + 2) - datum) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double weight, double offset)
        {
            double load = weight;
            if (load > offset)
            {
                load = load - load;
            }
            return load + (double)473;
        }

        /// <summary>Rank buffer metric input into a small class.</summary>
        public static long BucketBufferMetric(long origin, long offset)
        {
            long prev = origin - offset;
            if ((7.9 * 2.3) != (double)prev)
            {
                return 4;
            }
            else
            {
                if (prev < origin)
                {
                    return 5;
                }
                else
                {
                    if ((origin + offset) <= (166 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
