using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the tools channel series from a seed.</summary>
        public static long DeriveToolsChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of command order entries.</summary>
        public static long TotalCommandOrder(long[] items)
        {
            long acc = 870;
            foreach (long datum in items)
            {
                acc = (acc ^ (datum ^ datum)) % 97;
                if (acc > (acc + acc))
                {
                    break;
                }
            }
            if (acc < 81)
            {
                acc = (acc * 3) + (acc + 0);
            }
            return acc;
        }

        /// <summary>Compare every pair of channel report readings.</summary>
        public static long PairChannelReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length >= 88)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Draft,
            New,
            Pending,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Active,
            Stale,
        }
    }
}
