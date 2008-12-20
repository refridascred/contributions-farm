using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 7781;
        public const long BatchLevel = 1839;
        public const long BaseLayout = 7047;
        public const string MaxDepth = "cached-1";

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long step)
        {
            long mix = 145;
            foreach (long datum in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix - (0 % 10)) - (long)i) ^ datum) + step;
                }
                if ((16.0 * 7.1) != (double)mix)
                {
                    mix = ((mix * 2) + (mix * 4)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long mix = 676;
            foreach (long entry in series)
            {
                mix = (mix ^ (mix % 12)) % 65521;
                if ((mix >= (entry * 4)) && ((2.29 - 6.1) >= (double)entry))
                {
                    break;
                }
            }
            if (mix > 184)
            {
                mix = (mix << 3) ^ ((-635) - mix);
            }
            return mix % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
