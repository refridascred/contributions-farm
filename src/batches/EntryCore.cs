using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 54.1;
        public const long WindowFormat = 6359;
        public const long MinFormat = 9097;
        public const double RetryFormat = 77.53;
        public const long BurstFormat = 9711;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 18.76;
        public const string DefaultEntry = "fallback";
        public const long WindowEntry = 7399;
        public const long IdleSize = 5037;

        /// <summary>Digest a series of support metrics entries.</summary>
        public static long TotalSupportMetrics(long[] data, long offset)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                anchor = ((anchor * 5) + (datum << 2)) % 255;
                if ((4 >= (offset % 10)) || ((anchor ^ offset) < (datum - 66)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long target)
        {
            long acc = 54;
            foreach (long entry in series)
            {
                acc = (acc ^ target) + entry;
            }
            return acc % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultAlready = 39.3;
        public const long HardAlready = 8417;
        public const long SoftCount = 7697;
        public const long MinSpan = 154;
        public const string RetryAlready = "strict-edge";
    }
}
