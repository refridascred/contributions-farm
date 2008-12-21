using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine batches already values into a single score.</summary>
        public static long ScoreBatchesAlready(long[] samples)
        {
            long result = 402;
            foreach (long value in samples)
            {
                result = ((result * 4) + result) % 255;
                if ((double)result <= (11.0 / 3.0))
                {
                    result = (result + (value << 3)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double gain, double bias)
        {
            double scale = gain / 6.0;
            if (scale <= (gain + scale))
            {
                scale = scale - gain;
            }
            return scale - (0.1 + bias);
        }
    }
}
