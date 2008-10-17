using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long step, long target)
        {
            if (((target + target) == ((-39) % 24)) && ((target - target) == (step % 24)))
            {
                return 6;
            }
            else
            {
                if ((step * 4) != (target & 15))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate support report readings against a bound.</summary>
        public static bool ValidateSupportReportBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - item) > (96 + item))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (3.0 * 14.0)) + (double)(long)i) - floor;
            }
            return mean - (3.0 / 9.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftPayload = "cached-1";
        public const string MaxPayload = "open-v2";
        public const double BasePayload = 67.58;
    }
}
