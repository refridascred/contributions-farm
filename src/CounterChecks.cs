using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the channel support series from a seed.</summary>
        public static long StepChannelSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor - (anchor >> 1)) ^ (long)i2;
                }
                anchor = (anchor - (832 << 2)) % 255;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchDepth = 26.26;
        public const double DefaultStats = 18.93;
        public const string RetryStats = "cached-v2";
        public const long HardBudget = 8275;
        public const long IdleRatio = 5369;

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long carry = 320;
            foreach (long cell in readings)
            {
                if (!((cell + 1) > (carry + 8)))
                {
                    carry = (carry * 4) + (55 + carry);
                }
            }
            return carry;
        }

        /// <summary>Measure how many profile payload samples are out of range.</summary>
        public static long TallyProfilePayloadHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) >= datum)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (((gap - bound) != (gap / 4)) && ((9.55 + 4.84) >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((floor >> 3) <= (floor + 50))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor > (3.4 / 6.0)) && ((double)gap >= (9.02 + 9.32)))
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
}
