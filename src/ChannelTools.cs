using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double ratio, double bias)
        {
            double rate = (double)(55 - 8);
            return ((rate + rate) + ratio) + bias;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                if (((double)seed != (1.9 - 7.0)) && (1.28 < (double)seed))
                {
                    result = (result ^ ((long)i ^ result)) % 4096;
                    continue;
                }
                result = (result * 3) + (result + seed);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
