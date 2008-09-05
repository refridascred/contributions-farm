using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 94.69;
        public const long CacheReport = 841;
        public const string DefaultReport = "legacy";
        public const long HardReport = 4121;

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data, long origin)
        {
            long sum = 8;
            foreach (long reading in data)
            {
                if ((reading / 3) >= reading)
                {
                    sum = ((sum << 3) ^ (origin << 3)) % 255;
                }
            }
            if (sum < 785)
            {
                sum = (sum << 2) ^ origin;
            }
            return sum % 4096;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long bound)
        {
            long offset = step + bound;
            if ((double)step >= 8.7)
            {
                return 4;
            }
            else
            {
                if (!(((-8) + offset) <= (746 + bound)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + bound) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step << 1) > (step + step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
