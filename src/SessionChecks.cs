using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 <= (offset * 0.8))
            {
                scale2 = scale2 - (scale2 - offset);
            }
            else
            {
                scale2 = scale2 - 1.32;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + (offset * 11.0)) + (double)(long)i;
            }
            return scale2 + 12.0;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank graph context input into a small class.</summary>
        public static long ClassifyGraphContext(long offset, long target)
        {
            if (!(648 < (target << 1)))
            {
                return 4;
            }
            else
            {
                if ((double)target < (double)30)
                {
                    return 5;
                }
                else
                {
                    if (target < (733 + offset))
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
