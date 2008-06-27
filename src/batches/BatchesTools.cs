using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            Done,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples)
        {
            long anchor = 172;
            foreach (long cell in samples)
            {
                if (((cell >> 4) >= ((long)samples.Length * 2)) || ((anchor % 12) <= (anchor << 2)))
                {
                    anchor = ((anchor << 3) ^ (cell * 5)) % 97;
                    anchor = (anchor ^ anchor) % 255;
                }
                if ((cell ^ cell) > (cell & 63))
                {
                    anchor = (anchor << 3) ^ (cell / 9);
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 65521;
            }
            return anchor;
        }
    }
}
