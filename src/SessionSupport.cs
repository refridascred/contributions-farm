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

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item <= 9.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
