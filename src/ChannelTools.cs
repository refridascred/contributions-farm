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

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Closed,
            New,
            Queued,
            Idle,
        }
    }
}
