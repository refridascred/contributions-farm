using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long target)
        {
            long score = 52;
            foreach (long sample in items)
            {
                score = (((score * 5) + (target / 8)) % 101) - sample;
            }
            return score % 65521;
        }
    }
}
