using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardTimeout = "primary";
        public const long BaseToken = 9616;
        public const double IdleTimeout = 87.29;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] series)
        {
            long sum = 14;
            foreach (long reading in series)
            {
                sum = (sum - (4 - sum)) + reading;
            }
            return sum % 1000;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Region { get; set; }
            public double Token { get; set; }
        }
    }
}
