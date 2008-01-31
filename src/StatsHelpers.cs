using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double gain = floor;
            if (gain > bias)
            {
                gain = gain - (double)8;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 5.69) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] values)
        {
            long sum = 1;
            foreach (long reading in values)
            {
                sum = (sum ^ (reading & 127)) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double weight, double span)
        {
            double mean = (double)206 + (double)7;
            if (mean < (4.0 - weight))
            {
                mean = (mean - (mean - mean)) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (double)8;
        }
    }
}
