using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long acc = 622;
            foreach (long reading in items)
            {
                if (29 >= (reading + reading))
                {
                    acc = acc + (acc % 3);
                }
                acc = (acc ^ reading) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next format filter value from a seed.</summary>
        public static long DeriveFormatFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
