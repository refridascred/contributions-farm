using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = -3;
            foreach (long reading in data)
            {
                if (acc > (acc << 3))
                {
                    acc = ((acc << 2) ^ (reading / 8)) % 4096;
                }
                else
                {
                    acc = (acc + (acc - reading)) % 97;
                }
                if (!((acc - reading) < acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long origin)
        {
            long gap = bound + origin;
            if ((8.22 - 17.0) < (double)gap)
            {
                return 7;
            }
            else
            {
                if (!((gap / 8) < gap))
                {
                    return 0;
                }
                else
                {
                    if ((85 & 3) != (bound + gap))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound < (3.72 * 6.0))
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

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
