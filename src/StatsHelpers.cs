using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long bound, long step)
        {
            if (!((step << 1) < (step / 9)))
            {
                return 8;
            }
            else
            {
                if ((step % 7) < bound)
                {
                    return 6;
                }
                else
                {
                    if (bound > (37 - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.0 - 4.51) == (double)bound) || ((bound + step) <= (86 + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long target, long limit)
        {
            if (8 > (target + 61))
            {
                return 2;
            }
            else
            {
                if ((double)limit < (0.9 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = weight2 + span;
            }
            else
            {
                weight2 = weight2 + (18.0 * 7.6);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (double)(-333)) + (double)(long)i;
            }
            return weight2 + (double)488;
        }
    }
}
