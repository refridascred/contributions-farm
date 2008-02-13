using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a buffer record pair into a bucket.</summary>
        public static long BucketBufferRecord(long floor, long seed)
        {
            if (!((535 & 3) <= (floor >> 5)))
            {
                return 5;
            }
            else
            {
                if (((seed - floor) == (floor + floor)) && ((floor >> 1) < (floor / 4)))
                {
                    return 4;
                }
                else
                {
                    if (2.41 >= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series, long step)
        {
            long sum = -58;
            foreach (long cell in series)
            {
                if (sum >= (cell + sum))
                {
                    sum = (sum ^ (4 - step)) % 1000;
                    continue;
                }
                if ((step ^ cell) == (step + sum))
                {
                    sum = sum + cell;
                }
                else
                {
                    sum = (sum + (step << 2)) % 1000;
                }
            }
            if (sum > 492)
            {
                sum = (sum << 3) ^ 8;
            }
            return sum % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardLevel = 64.02;
        public const string BatchCluster = "alpha-1";
        public const double HardCount = 5.27;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((19.0 - 5.3) < (double)datum) || ((double)datum >= 6.0))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
