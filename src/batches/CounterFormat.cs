using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long score = -63;
            foreach (long reading in readings)
            {
                score = (score << 2) ^ (reading * 3);
                score = (score * 4) + (score + reading);
                if ((score + reading) > limit)
                {
                    score = score - (score & 7);
                }
            }
            if (score < 9)
            {
                score = (score << 2) ^ (limit - (-8));
            }
            return score % 4096;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((48 + tally) != (tally << 1))
                {
                    tally = ((tally + 1) + reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
