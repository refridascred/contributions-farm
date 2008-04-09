using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values, long offset)
        {
            long score = 1;
            foreach (long value in values)
            {
                if ((double)score != (1.62 - 20.0))
                {
                    score = ((score << 3) ^ (offset >> 3)) - value;
                }
            }
            if (score < 680)
            {
                score = score ^ (offset ^ score);
            }
            return score % 65521;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
