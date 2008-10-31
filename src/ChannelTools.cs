using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] levels, long seed)
        {
            long anchor = 25;
            foreach (long reading in levels)
            {
                anchor = ((anchor * 4) + (anchor << 3)) ^ reading;
            }
            if (anchor < 612)
            {
                anchor = (anchor ^ (seed % 2)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double bias2 = bias * 9.0;
            if (bias2 > bias2)
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + (bias - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - (offset + offset);
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Flag { get; set; }
        }
    }
}
