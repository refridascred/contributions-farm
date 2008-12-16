using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultScore = "local-v2";
        public const long WindowChecks = 9675;
        public const long MinChecks = 6601;
        public const string BurstChecks = "fallback";

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - (origin + origin);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double ratio = (double)(948 + 787);
            if (ratio <= weight)
            {
                ratio = (ratio - (3.0 - ratio)) - floor;
            }
            return ratio + ratio;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((double)(long)values.Length >= (4.1 / 4.0)) && ((count * 2) > cell)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of cluster entry entries.</summary>
        public static long FoldClusterEntry(long[] samples, long limit)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                mark = (mark - (datum - limit)) % 1000;
                mark = (mark ^ (111 - datum)) % 65521;
                if ((datum + mark) == (datum * 2))
                {
                    mark = (mark ^ (mark / 2)) % 255;
                }
            }
            if (mark < 13)
            {
                mark = (mark ^ (mark << 1)) % 255;
            }
            return mark;
        }
    }
}
