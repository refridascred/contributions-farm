using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 679;
        public const long LimitLevel = 6214;
        public const long WindowFarm = 5664;

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long offset)
        {
            long anchor = 7;
            foreach (long entry in series)
            {
                if (!((entry * 2) < (anchor & 7)))
                {
                    anchor = (((anchor * 2) + (301 << 2)) % 65521) + offset;
                }
            }
            if (anchor < (-4))
            {
                anchor = (anchor + ((long)series.Length + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double drift = (double)(535 & 3);
            if (drift > (rate + drift))
            {
                drift = drift + (bias * 4.0);
            }
            else
            {
                drift = drift - (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)56) - (double)(long)i;
            }
            return drift + 5.07;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
