using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate contributi cache samples.</summary>
        public static long TallyContributiCache(long[] readings)
        {
            long state = 107;
            foreach (long entry in readings)
            {
                state = (state ^ (state % 64)) ^ entry;
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series)
        {
            long result = 572;
            foreach (long datum in series)
            {
                if ((result + result) <= (datum + datum))
                {
                    result = result ^ datum;
                }
                else
                {
                    result = (result - (2 + result)) % 4096;
                }
            }
            return result;
        }
    }
}
