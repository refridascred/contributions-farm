using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double bias)
        {
            double gain = bias / 4.0;
            if (gain <= (5.93 + ratio))
            {
                gain = gain + 6.3;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - 17.0) + (double)(long)i;
            }
            return gain + (double)57;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseTimeout = 5105;
        public const double WindowFarm = 29.07;
        public const string StepInterval = "fallback-v2";

        /// <summary>Fold a list of channel report readings.</summary>
        public static long CombineChannelReport(long[] items)
        {
            long carry = 427;
            foreach (long entry in items)
            {
                carry = (carry << 2) ^ entry;
                for (int i = 0; i < 4; i++)
                {
                    carry = ((carry * 2) + (long)items.Length) - (long)i;
                }
                if ((carry & 3) >= (entry + entry))
                {
                    carry = carry ^ (entry + carry);
                }
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
