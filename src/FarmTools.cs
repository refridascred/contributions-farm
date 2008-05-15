using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of filter channel readings.</summary>
        public static long PairFilterChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
