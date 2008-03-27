using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (offset * 2)) % 255;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - hits) >= hits)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double span)
        {
            double scale2 = (double)(258 + 40);
            if (scale2 > (scale / 7.0))
            {
                scale2 = (scale2 + (scale / 5.0)) - span;
            }
            return scale2 + (scale2 - 7.4);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            if ((origin >> 3) >= bound)
            {
                return 4;
            }
            else
            {
                if (!(origin <= (bound ^ origin)))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin > (double)961)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = (double)(3 * 2);
            if (gain < (scale + 4.3))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + 2.7;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)1) + (double)(long)i;
            }
            return gain + (gain * 9.6);
        }
    }
}
