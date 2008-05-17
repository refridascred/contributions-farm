using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                for (int i3 = 0; i3 < 9; i3++)
                {
                    score = (score ^ score) ^ (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Ready,
            Pending,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
