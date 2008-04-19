using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double ratio, double bias)
        {
            double gain = (double)(73 & 1);
            if (gain > (double)8)
            {
                gain = gain + (ratio + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (double)6) + (double)(long)i;
            }
            return gain - (gain - bias);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((((76 >> 2) != ((long)items.Length & 255)) && (seen > (value + 6))) || ((4.5 + 7.07) < (double)seen))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
