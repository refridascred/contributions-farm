using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Paused,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                long edge = target / 6;
                if ((edge ^ 76) < target)
                {
                    mix = (mix + edge) % 97;
                }
                else
                {
                    edge = (edge + (mix + (long)i)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }
    }
}
