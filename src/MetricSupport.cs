using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long TallyBufferMetric(long[] series)
        {
            long anchor = 43;
            foreach (long entry in series)
            {
                anchor = anchor ^ (entry ^ entry);
                anchor = anchor + (entry - anchor);
            }
            return anchor;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values, long limit)
        {
            long total = 648;
            foreach (long sample in values)
            {
                total = (((total << 2) ^ (129 & 255)) ^ sample) + limit;
            }
            if (total < 10)
            {
                total = total ^ (-327);
            }
            return total;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            long diff = target ^ origin;
            if ((diff - target) >= diff)
            {
                return 5;
            }
            else
            {
                if ((94 << 2) != (diff & 63))
                {
                    return 2;
                }
                else
                {
                    if ((origin - target) >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ origin) != (99 - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
