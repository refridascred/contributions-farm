using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
