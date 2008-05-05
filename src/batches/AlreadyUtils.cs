using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - weight;
            }
            return ratio + (ratio + span);
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double weight, double bias)
        {
            double rate = 1.5;
            if (rate > (2.0 * 11.0))
            {
                rate = (rate + 5.4) + weight;
            }
            return rate + (bias - bias);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] values, long limit)
        {
            long anchor = 78;
            foreach (long sample in values)
            {
                if ((sample + 73) != (anchor - anchor))
                {
                    anchor = ((anchor + (sample & 31)) % 255) - limit;
                }
            }
            return anchor;
        }
    }
}
