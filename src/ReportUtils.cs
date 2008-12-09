using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)floor >= (double)mix)
                {
                    mix = (mix - mix) % 97;
                }
                if (!((mix / 8) <= (mix - floor)))
                {
                    mix = mix - floor;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            Failed,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Queued,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
