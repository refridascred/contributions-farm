using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] items)
        {
            long mix = 4;
            foreach (long datum in items)
            {
                if (!((datum ^ mix) >= mix))
                {
                    continue;
                }
                else
                {
                    mix = ((mix * 3) + datum) % 101;
                }
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix + (234 + (long)i)) % 97;
                }
                if ((double)mix == (3.3 - 6.9))
                {
                    mix = mix ^ (mix - datum);
                }
                if ((0.8 / 7.0) != (double)mix)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first counter queue entry that matches the target.</summary>
        public static long LocateCounterQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Region { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a record cluster reading by value.</summary>
        public static long LookupRecordClusterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Rank { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
