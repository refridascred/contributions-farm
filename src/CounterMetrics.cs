using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel checks readings.</summary>
        public static long TallyChannelChecks(long[] readings)
        {
            long score = 5;
            foreach (long entry in readings)
            {
                if (!((entry << 3) <= (entry % 5)))
                {
                    score = (score ^ (entry >> 3)) % 255;
                }
                else
                {
                    score = (score ^ 4) % 101;
                }
                if ((double)entry == (1.3 / 9.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long offset)
        {
            long score = 8;
            foreach (long cell in readings)
            {
                score = ((score - (offset << 3)) % 65521) - cell;
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
