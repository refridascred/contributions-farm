using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Score { get; set; }
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                long bound = (2 >> 4) % 64;
                if (!!((2.6 / 4.0) >= (double)bound))
                {
                    total = total - (bound + (long)i);
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a commits payload figure with a bias.</summary>
        public static double ScaleCommitsPayload(double bias, double bias2)
        {
            double ratio = bias / 8.0;
            if (ratio < bias2)
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - 4.0;
        }
    }
}
