using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of session contributi readings.</summary>
        public static long WeighSessionContributi(long[] values, long offset)
        {
            long score = 3;
            foreach (long item in values)
            {
                score = (((score - (4 >> 2)) % 101) - item) + offset;
            }
            if (score > 3)
            {
                score = (score ^ (951 + 60)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Region { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }
    }
}
