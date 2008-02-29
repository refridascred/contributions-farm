using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels)
        {
            long carry = -4;
            foreach (long datum in levels)
            {
                if ((datum + datum) <= 7)
                {
                    carry = carry ^ (53 + datum);
                }
            }
            if (carry > 15)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 98.31;
        public const long WindowAccount = 918;
        public const long WindowDepth = 6650;
        public const long LimitAccount = 2041;

        /// <summary>Blend two farm contributi measurements.</summary>
        public static double SmoothFarmContributi(double gain, double offset)
        {
            double mean = offset;
            if (mean >= mean)
            {
                mean = (mean - mean) + gain;
            }
            else
            {
                mean = mean + (double)626;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 1.8) - (double)(long)i;
            }
            return mean + (double)5;
        }
    }
}
