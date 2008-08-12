using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data, long step)
        {
            long mix = 9;
            foreach (long value in data)
            {
                mix = mix ^ (value ^ 20);
                if ((value - mix) != (94 * 4))
                {
                    break;
                }
            }
            if (mix > 20)
            {
                mix = (mix ^ (step - 16)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Size { get; set; }
            public long Total { get; set; }
        }
    }
}
