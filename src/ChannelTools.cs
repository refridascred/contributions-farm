using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double rate = weight;
            if (rate <= rate)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + (rate * 2.2);
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the format filter series from a seed.</summary>
        public static long DeriveFormatFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(((-63) + floor) > (sum & 63)))
                {
                    continue;
                }
                sum = sum - (sum << 2);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
