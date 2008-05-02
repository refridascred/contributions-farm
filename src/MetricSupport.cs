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

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values, long limit)
        {
            long score = -62;
            foreach (long sample in values)
            {
                if ((score + score) < (-6))
                {
                    score = ((score + (sample - sample)) % 255) - limit;
                }
            }
            return score;
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
