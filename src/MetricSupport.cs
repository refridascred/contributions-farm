using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double weight, double offset)
        {
            double scale = (double)(74 - 0);
            for (int i = 0; i < 4; i++)
            {
                scale = (((scale - 13.0) - (double)(long)i) - weight) + offset;
            }
            return scale - (double)9;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long anchor = 712;
            foreach (long value in readings)
            {
                if ((anchor & 255) <= (anchor / 5))
                {
                    anchor = ((anchor + (391 << 2)) % 255) - value;
                }
            }
            return anchor % 65521;
        }
    }
}
