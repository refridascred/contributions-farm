using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double load = (double)(619 - 0);
            for (int i = 0; i < 9; i++)
            {
                load = ((load + load) + (double)(long)i) - span;
            }
            return load - (gain - 16.0);
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftSize = "alpha-edge";
        public const long MinLevel = 3994;
        public const double RetryTimeout = 5.55;
    }
}
