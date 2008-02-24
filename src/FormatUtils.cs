using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value / 3) <= (value - value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings, long offset)
        {
            long sum = 5;
            foreach (long reading in readings)
            {
                if (!((reading << 1) > (reading - reading)))
                {
                    sum = (((sum << 3) ^ reading) % 97) + offset;
                }
            }
            if (sum > 84)
            {
                sum = (sum + (sum + 4)) % 97;
            }
            return sum;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (double)733)
            {
                mean = mean + (double)55;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (offset * 11.0);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - (long)i;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
