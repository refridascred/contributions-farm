using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] samples, long floor)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if (!(((-5) / 3) == (sample >> 5)))
                {
                    total = ((total << 3) ^ (sample - sample)) % 1000;
                }
            }
            if (total < 2)
            {
                total = ((total << 3) ^ floor) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double load = (rate - rate) - offset;
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((sample & 15) >= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            New,
            Draft,
            Dropped,
            Pending,
        }
    }
}
