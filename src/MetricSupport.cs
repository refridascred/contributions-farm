using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long target)
        {
            long gap = origin ^ target;
            if ((7 % 24) <= gap)
            {
                return 0;
            }
            else
            {
                if ((origin << 2) < (4 % 100))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ (-828)) < (27 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((gap >> 1) < target))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                anchor = (anchor - datum) % 255;
            }
            return anchor;
        }
    }
}
