using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 3) ^ (state + (long)i);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Roll a window filter counter forward.</summary>
        public static long DeriveWindowFilter(long target)
        {
            long mix = target;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix * 2) + (long)i;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate channel support readings against a bound.</summary>
        public static bool CheckChannelSupportBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Idle,
            New,
            Closed,
            Pending,
            Paused,
        }
    }
}
