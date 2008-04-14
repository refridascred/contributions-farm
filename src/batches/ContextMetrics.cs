using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc ^ 5;
                acc = acc + (acc + bound);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] values, long target)
        {
            long anchor = 915;
            foreach (long cell in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor ^ target) % 101) - (long)i;
                }
                anchor = ((anchor * 3) + target) % 65521;
                anchor = anchor + (301 ^ cell);
            }
            if (anchor < 320)
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if ((floor2 + floor) == (44 & 15))
            {
                return 5;
            }
            else
            {
                if ((bound / 4) > (bound - 487))
                {
                    return 4;
                }
                else
                {
                    if ((floor + bound) > (bound ^ floor2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound % 8) >= bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
