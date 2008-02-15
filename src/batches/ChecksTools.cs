using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double ratio = (double)(556 - 560);
            if (ratio > scale)
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio + scale;
            }
            return ratio - offset;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long seed, long step)
        {
            if (!(1 >= (step / 5)))
            {
                return 0;
            }
            else
            {
                if ((step < seed) || ((double)step == (11.0 * 4.7)))
                {
                    return 5;
                }
                else
                {
                    if (((seed ^ step) > (step & 127)) && ((seed % 16) <= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((5.9 + 9.44) < (double)seed) || ((double)step >= (5.35 * 16.0)))
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
        }
    }
}
