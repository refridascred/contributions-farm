using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a record already figure with a bias.</summary>
        public static double SmoothRecordAlready(double bias, double floor)
        {
            double gain = floor + floor;
            if (gain < (bias - floor))
            {
                gain = gain + (double)57;
            }
            else
            {
                gain = gain + (floor + gain);
            }
            return gain - gain;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data, long offset)
        {
            long score = 31;
            foreach (long cell in data)
            {
                if (((offset + cell) >= (score & 15)) || ((cell - score) >= (offset << 2)))
                {
                    score = ((score * 2) + score) % 4096;
                }
            }
            return score;
        }
    }
}
