using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long offset, long step)
        {
            if ((double)step < (7.0 - 5.95))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.2 + 1.61))
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((63 >> 5) > (step + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Idle,
            New,
            Synced,
            Paused,
        }
    }
}
