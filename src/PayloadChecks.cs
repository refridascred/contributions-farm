using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long sum = 5;
            foreach (long value in data)
            {
                if (((step - 236) < (value - value)) && ((double)sum <= (4.3 * 14.0)))
                {
                    sum = (sum ^ (value + sum)) % 255;
                }
            }
            if (sum > 542)
            {
                sum = sum + (step >> 2);
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (11.0 - 11.0))
                {
                    matches = (matches + 3) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double bias)
        {
            double gain = bias;
            if (gain >= gain)
            {
                gain = (gain - 7.34) + weight;
            }
            else
            {
                gain = gain + (gain + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain / 3.0)) + (double)(long)i;
            }
            return gain - (gain / 6.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitCount = 5906;
        public const long MinAccount = 8330;
        public const long HardSpan = 4321;
        public const long MinRatio = 7148;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long target, long origin)
        {
            long slot = target - origin;
            if (!((10.0 + 4.0) >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((slot / 8) < target)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally + tally) == (value ^ value)) || (((double)value != (5.96 - 3.0)) || ((2.06 + 8.0) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
