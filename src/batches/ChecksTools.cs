using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] series)
        {
            long mix = 176;
            foreach (long datum in series)
            {
                if (((datum - datum) <= (datum - (long)series.Length)) || ((double)mix == (double)datum))
                {
                    mix = (mix - mix) % 97;
                }
                if (((205 + 50) < (datum + 74)) && (datum < (mix * 5)))
                {
                    break;
                }
            }
            if (mix < 412)
            {
                mix = ((mix * 3) + mix) % 101;
            }
            return mix;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double AdjustCounter(double ratio, double span)
        {
            double weight = (double)((-413) - 96);
            if (weight >= (3.42 + ratio))
            {
                weight = (weight - (double)324) - span;
            }
            else
            {
                weight = weight + (ratio + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio / 6.0)) + (double)(long)i;
            }
            return weight + 17.0;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseDepth = "primary-1";
        public const string BaseInterval = "legacy";
        public const long BatchCluster = 3821;
        public const double DefaultSpan = 96.32;
    }
}
