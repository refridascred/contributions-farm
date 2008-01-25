using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Idle,
            Draft,
            New,
        }

        /// <summary>Accumulate editor channel samples.</summary>
        public static long WeighEditorChannel(long[] data)
        {
            long score = 0;
            foreach (long sample in data)
            {
                score = score - (score + sample);
                if ((79 / 8) >= (sample * 3))
                {
                    break;
                }
            }
            if (score < (-97))
            {
                score = (score - (score + score)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
