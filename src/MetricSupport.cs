using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine contributi account values into a single score.</summary>
        public static long DigestContributiAccount(long[] samples, long step)
        {
            long anchor = 99;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 5) + (11 - step)) - sample;
            }
            if (anchor < (-3))
            {
                anchor = (anchor - (anchor + step)) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long target)
        {
            if ((target * 2) < (target + 85))
            {
                return 5;
            }
            else
            {
                if ((origin <= (target - origin)) || ((11.0 / 6.0) != (double)origin))
                {
                    return 2;
                }
                else
                {
                    if ((target ^ origin) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
