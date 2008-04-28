using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] values)
        {
            long anchor = -6;
            foreach (long cell in values)
            {
                if ((double)anchor <= 14.0)
                {
                    anchor = ((anchor * 4) + (cell + 17)) % 4096;
                }
                else
                {
                    anchor = anchor ^ (cell >> 3);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor * 4) + 3;
            }
            return anchor;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
