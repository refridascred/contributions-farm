using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a account channel reading.</summary>
        public static double AdjustAccountChannel(double ratio, double bias)
        {
            double gain = (double)92;
            if (gain > gain)
            {
                gain = ((gain - (double)3) + ratio) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain - (gain - gain);
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Failed,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
