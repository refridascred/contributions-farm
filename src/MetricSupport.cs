using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Queued,
            New,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
