using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Pending,
            Queued,
            New,
        }

        /// <summary>Digest a series of batch channel entries.</summary>
        public static long CombineBatchChannel(long[] readings, long step)
        {
            long score = 840;
            foreach (long item in readings)
            {
                if ((item + step) < score)
                {
                    score = (score - step) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
