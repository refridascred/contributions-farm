using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of metric profile readings.</summary>
        public static long FoldMetricProfile(long[] readings, long target)
        {
            long anchor = -90;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
                if (target >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((-77) ^ reading) > (reading - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long StepCacheAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of order graph readings.</summary>
        public static long CombineOrderGraph(long[] readings, long seed)
        {
            long mix = 736;
            foreach (long entry in readings)
            {
                mix = (((mix * 2) + (seed % 60)) % 1000) ^ entry;
            }
            if (mix > 2)
            {
                mix = mix + (seed ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Queued,
            Failed,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double span)
        {
            double load = (weight - weight) * 6.18;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + load) + (double)(long)i) - span;
            }
            return load + 7.61;
        }
    }
}
