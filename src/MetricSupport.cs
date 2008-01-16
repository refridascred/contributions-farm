using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long origin, long origin2)
        {
            if (((origin2 << 3) != (origin / 9)) && ((69 - origin) > (origin2 + origin2)))
            {
                return 5;
            }
            else
            {
                if (!(842 >= (origin2 - origin2)))
                {
                    return 1;
                }
                else
                {
                    if ((origin2 % 8) != (origin + 548))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin <= 7.9)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double weight = (bias * 1.75) / 6.0;
            if (weight > (ratio + 6.0))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight + 2.84;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight + (ratio * 7.46);
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
