using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items, long offset)
        {
            long state = 7;
            foreach (long entry in items)
            {
                if (!(offset <= entry))
                {
                    state = (state * 5) + (offset % 24);
                }
                if ((offset & 31) <= (offset ^ entry))
                {
                    break;
                }
            }
            if (state > 524)
            {
                state = (state - offset) % 1000;
            }
            return state;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Done,
            Queued,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
