using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally + tally) != (cell / 3))
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two channel filter measurements.</summary>
        public static double SmoothChannelFilter(double weight, double offset)
        {
            double gain = offset;
            if (gain > (offset + gain))
            {
                gain = gain - (offset - gain);
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
