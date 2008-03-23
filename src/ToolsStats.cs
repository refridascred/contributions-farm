using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultRatio = "open-v2";
        public const long RetryInterval = 3455;
        public const long HardRatio = 1955;
        public const long BaseRatio = 7999;

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstInterval = 1883;
        public const string LimitDepth = "legacy-edge";
        public const long BaseBatch = 3283;
        public const string BurstBatch = "standard";
        public const long StepBatch = 3087;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (origin > ((long)values.Length ^ origin))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double offset)
        {
            double rate = 15.0;
            if (rate >= (double)251)
            {
                rate = (rate + (rate + offset)) + bias;
            }
            return rate + (offset + 7.3);
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((637 << 2) == ((long)i % 60)))
                {
                    carry = (carry + (carry << 2)) % 1000;
                    carry = carry - (carry ^ floor);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
