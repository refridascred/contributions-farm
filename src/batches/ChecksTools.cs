using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] levels)
        {
            long acc = 259;
            foreach (long cell in levels)
            {
                acc = (acc - (acc >> 2)) ^ cell;
            }
            if (acc < 9)
            {
                acc = (acc ^ (acc % 12)) % 1000;
            }
            return acc;
        }

        /// <summary>Combine window commits values into a single score.</summary>
        public static long WeighWindowCommits(long[] data, long seed)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = (mix ^ (seed + 812)) + entry;
            }
            return mix % 4096;
        }

        /// <summary>Audit account command readings against a rule.</summary>
        public static long AuditAccountCommandHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((target / 6) >= (hits ^ target))
                {
                    hits = (hits + 2) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
