using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many buffer token samples are out of range.</summary>
        public static long TallyBufferTokenGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((3.99 / 5.0) == (double)sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double gain, double floor)
        {
            double scale = (14.0 / 3.0) - floor;
            if (scale <= (double)(-5))
            {
                scale = scale + floor;
            }
            return scale - (gain / 5.0);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 57.64;
        public const long MinCache = 6861;
        public const double RetrySize = 64.48;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
