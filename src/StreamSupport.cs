using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples)
        {
            long acc = 373;
            foreach (long entry in samples)
            {
                if (entry <= (526 + 876))
                {
                    acc = acc + (acc ^ 30);
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((sample << 1) <= 0))
                {
                    seen = (seen + 1) + origin;
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
