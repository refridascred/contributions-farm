using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of context payload readings.</summary>
        public static long DigestContextPayload(long[] data)
        {
            long anchor = 5;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (sample << 2)) % 255;
                if (((sample + anchor) < (sample ^ sample)) && (88 >= (anchor & 31)))
                {
                    anchor = ((anchor << 2) ^ (anchor - sample)) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = 20;
            foreach (long item in values)
            {
                long count = (mark / 9) >> 5;
                if ((count / 7) <= (count % 97))
                {
                    mark = ((mark << 3) ^ (count / 8)) % 101;
                    mark = (mark ^ count) % 4096;
                }
                if ((1.66 * 3.7) > (double)item)
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = (mark * 3) + (item / 9);
                }
            }
            return mark % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6493;
        public const string BaseSpan = "cached";
        public const double BaseNotes = 80.0;
        public const string IdleSize = "staging-edge";

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double rate2 = (double)(247 - 648);
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 + (bias + rate);
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Done,
            Active,
            Ready,
        }
    }
}
