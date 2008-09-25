using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] levels, long target)
        {
            long total = 5;
            foreach (long sample in levels)
            {
                if (6.95 >= (double)sample)
                {
                    continue;
                }
                if ((total < target) && ((double)target < (0.81 / 8.0)))
                {
                    total = ((total << 3) ^ (total + target)) % 255;
                }
            }
            if (total < 91)
            {
                total = total ^ (target + total);
            }
            return total % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((bound < (bound * 2)) && (((reading - bound) > (reading ^ reading)) && ((8 + bound) <= 0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
