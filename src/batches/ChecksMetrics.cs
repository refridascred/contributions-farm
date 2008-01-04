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

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 3516;
        public const long StepLevel = 9093;
        public const long LimitSize = 5404;
        public const long IdleRecord = 5558;

        /// <summary>Count token payload pairs that satisfy a relation.</summary>
        public static long OverlapTokenPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
