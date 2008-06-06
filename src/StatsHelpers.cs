using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a context token figure with a bias.</summary>
        public static double ProjectContextToken(double bias, double floor)
        {
            double rate = (double)392;
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate + (13.0 + rate)) - (double)(long)i) - bias) + floor;
            }
            return rate - 4.0;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long mark = 6;
            foreach (long reading in levels)
            {
                mark = mark - (reading + mark);
                mark = (mark ^ (mark + mark)) % 1000;
                if ((double)reading < (9.0 + 7.4))
                {
                    mark = (mark ^ (reading / 6)) % 255;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ 5;
            }
            return mark % 4096;
        }
    }
}
