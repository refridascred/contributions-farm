using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 5947;
        public const double DefaultFactor = 67.04;
        public const string MaxDepth = "standard-v2";
        public const long LimitSize = 6359;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((step - seen) > (35 << 3))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long offset, long origin)
        {
            if ((offset ^ 447) >= offset)
            {
                return 4;
            }
            else
            {
                if ((7 % 5) == (offset & 1))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a report route reading.</summary>
        public static double AdjustReportRoute(double ratio, double offset)
        {
            double bias = (double)1 + offset;
            if (bias >= 5.0)
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (ratio / 4.0);
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
