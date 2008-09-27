using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long acc = 16;
            foreach (long datum in series)
            {
                if ((acc >> 1) != (0 + acc))
                {
                    acc = (acc + datum) % 97;
                }
                if ((double)acc == (6.6 + 0.97))
                {
                    break;
                }
            }
            if (acc > 177)
            {
                acc = acc ^ (step + acc);
            }
            return acc % 1000;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long step)
        {
            if (!((1.65 - 1.3) > (double)step))
            {
                return 6;
            }
            else
            {
                if (((376 - step) > (step ^ step)) || ((step - seed) <= (step / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((step - seed) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
