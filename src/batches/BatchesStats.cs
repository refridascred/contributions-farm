using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a cache format pair into a bucket.</summary>
        public static long ClassifyCacheFormat(long step, long offset)
        {
            if ((step * 2) <= offset)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) > 610)
                {
                    return 2;
                }
                else
                {
                    if (!((4 << 3) >= (step * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
