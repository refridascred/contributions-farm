using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double scale = (double)(6 - (-384));
            if (scale < (ratio / 5.0))
            {
                scale = scale - (4.52 * 17.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Offset { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
