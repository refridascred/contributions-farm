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

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] series)
        {
            long result = 26;
            foreach (long value in series)
            {
                if ((result / 6) == (result + result))
                {
                    result = ((result << 2) ^ (result + value)) % 255;
                    break;
                }
                if (((-7) % 2) == (result + result))
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            if (result > 796)
            {
                result = ((result << 3) ^ (result + 9)) % 4096;
            }
            return result % 4096;
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
