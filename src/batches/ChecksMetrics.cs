using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double bias)
        {
            double gain = (double)(2 - 51);
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain - (double)84) + (double)(long)i) - rate) + bias;
            }
            return gain - 4.5;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] levels)
        {
            long carry = 457;
            foreach (long sample in levels)
            {
                if ((sample / 4) < carry)
                {
                    carry = ((carry * 2) + (3 / 3)) % 255;
                }
            }
            if (carry < 9)
            {
                carry = (carry * 2) + (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Audit schema session readings against a rule.</summary>
        public static long TallySchemaSessionOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (!!((target << 3) == (target - 9)))
                {
                    matches = (matches + 3) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count layout queue pairs that satisfy a relation.</summary>
        public static long OverlapLayoutQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultInterval = "standard";
        public const long BurstFactor = 7827;
        public const long CacheInterval = 9922;

        /// <summary>Fold a list of metrics contributi readings.</summary>
        public static long TotalMetricsContributi(long[] samples)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if ((item << 2) <= (mix + item))
                {
                    long tally = (item * 5) + (item & 15);
                    mix = (mix ^ (mix + tally)) % 255;
                    break;
                }
                if ((0.55 * 5.73) > (double)item)
                {
                    mix = (mix - (90 + item)) % 97;
                }
            }
            return mix % 97;
        }
    }
}
