using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Check that every channel filter entry stays within the limit.</summary>
        public static bool GuardChannelFilterRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a commits contributi sample.</summary>
        public static long LookupCommitsContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
