using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Active,
            Retry,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Digest a series of notes stream entries.</summary>
        public static long WeighNotesStream(long[] series)
        {
            long mix = 628;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix - (sample >> 5)) % 255;
                    mix = (mix + ((long)i + sample)) % 101;
                }
                if ((sample & 255) > (25 & 15))
                {
                    mix = (mix << 3) ^ (mix ^ (-5));
                }
            }
            return mix;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double weight = (double)7 + 3.4;
            if (weight > (span / 4.0))
            {
                weight = (weight - span) - gain;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (double)75;
        }
    }
}
