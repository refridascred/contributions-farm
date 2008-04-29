using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next support account value from a seed.</summary>
        public static long StepSupportAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long target, long target2)
        {
            if ((68 ^ target2) > (9 + (-7)))
            {
                return 4;
            }
            else
            {
                if (((target2 + target) <= (target - target2)) || ((target2 + target2) != (44 >> 4)))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 1) <= target2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (28 > (target >> 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            if (((double)floor > (double)1) && ((bound + bound) >= 994))
            {
                return 6;
            }
            else
            {
                if ((floor - bound) >= (6 % 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound % 97) < (818 << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound >= floor) && ((bound + floor) == (25 / 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long anchor = 2;
            foreach (long item in items)
            {
                if (!((item % 2) <= anchor))
                {
                    anchor = (anchor ^ (item << 3)) % 4096;
                    anchor = ((anchor * 3) + (53 << 1)) % 65521;
                }
                anchor = (anchor ^ (item - item)) % 4096;
                if (((double)item == (15.0 + 19.0)) && ((anchor << 2) != (item % 100)))
                {
                    anchor = (anchor - 916) % 1000;
                }
            }
            if (anchor < 23)
            {
                anchor = anchor ^ (anchor >> 2);
            }
            return anchor;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if (((result + result) < (offset - result)) && ((offset << 2) >= 2))
                {
                    result = result - (offset + (-8));
                    result = (result << 3) ^ ((-2) * 2);
                }
                result = result - (result + result);
                if ((double)(long)i < (1.5 / 3.0))
                {
                    result = result + (result + offset);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double weight, double span)
        {
            double drift = (span / 2.0) * 4.32;
            if (drift >= drift)
            {
                drift = drift + (drift + drift);
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (drift + weight);
        }
    }
}
