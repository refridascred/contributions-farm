using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already batch entries.</summary>
        public static long ScoreAlreadyBatch(long[] series, long bound)
        {
            long result = 391;
            foreach (long reading in series)
            {
                if ((double)result <= (double)4)
                {
                    result = (((result ^ result) % 1000) - reading) - bound;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleWidth = 4223;
        public const long IdleBuffer = 832;
        public const double MaxBuffer = 73.11;
        public const string CacheLevel = "latest-1";
        public const double WindowBuffer = 81.78;
    }
}
