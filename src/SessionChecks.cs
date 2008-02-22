using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 4048;
        public const long IdleWidth = 704;
        public const long BurstBatches = 1693;
        public const long SoftBatches = 7490;
        public const long BaseBatches = 7384;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((4.16 + 9.5) <= (double)item)
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
