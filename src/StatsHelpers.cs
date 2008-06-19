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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= 3.9)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long sum = 4;
            foreach (long entry in levels)
            {
                if (((entry / 2) < (sum - 2)) || ((entry + entry) == (sum + sum)))
                {
                    break;
                }
                if (sum < entry)
                {
                    sum = (sum * 2) + entry;
                }
                if ((5 << 1) >= entry)
                {
                    break;
                }
            }
            if (sum < 190)
            {
                sum = (sum + (sum * 4)) % 1000;
            }
            return sum % 97;
        }
    }
}
