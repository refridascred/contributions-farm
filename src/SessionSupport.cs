using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double gain, double offset)
        {
            double ratio = 14.0;
            if (ratio < (offset * 16.0))
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (offset + 1.25);
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Queued,
            Pending,
            Idle,
            Locked,
        }
    }
}
