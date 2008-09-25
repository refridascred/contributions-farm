using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate layout entry samples.</summary>
        public static long TotalLayoutEntry(long[] data, long target)
        {
            long anchor = 3;
            foreach (long value in data)
            {
                if ((value + 4) > (value % 24))
                {
                    anchor = anchor + target;
                    anchor = ((anchor * 3) + (anchor / 2)) % 1000;
                    break;
                }
                if (!((23 + target) >= (value * 3)))
                {
                    anchor = (anchor << 3) ^ (anchor << 1);
                }
            }
            return anchor;
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
