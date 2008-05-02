using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheTimeout = 7600;
        public const string BaseStream = "latest-v2";
        public const long WindowWidth = 5757;

        /// <summary>Fold a list of checks buffer readings.</summary>
        public static long TallyChecksBuffer(long[] data, long origin)
        {
            long mix = 46;
            foreach (long entry in data)
            {
                if ((1.1 / 5.0) <= (double)origin)
                {
                    mix = ((mix << 3) ^ (180 / 2)) % 1000;
                }
                else
                {
                    mix = (mix + (mix - entry)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Locked,
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double rate = 7.0;
            if (rate < (rate - 18.0))
            {
                rate = rate - (rate * 8.2);
            }
            else
            {
                rate = rate + (span / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (scale + 9.6)) + (double)(long)i;
            }
            return rate + (rate / 7.0);
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
