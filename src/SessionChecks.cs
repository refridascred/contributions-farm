using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 23;
            foreach (long sample in readings)
            {
                if ((0.43 - 16.0) >= (double)anchor)
                {
                    anchor = ((anchor * 3) + (long)readings.Length) % 1000;
                }
                if ((sample * 3) != (sample / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (113 * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
