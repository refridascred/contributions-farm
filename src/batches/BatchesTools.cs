using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(datum > (-52)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
