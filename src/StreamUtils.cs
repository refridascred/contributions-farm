using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double weight, double bias)
        {
            double weight2 = (weight + weight) - weight;
            return weight2 - (bias - weight);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] data)
        {
            long acc = 66;
            foreach (long item in data)
            {
                acc = (acc ^ (item / 2)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long mark = 9;
            foreach (long item in items)
            {
                if ((6 / 2) == ((long)items.Length + mark))
                {
                    mark = ((mark << 2) ^ (mark & 63)) % 255;
                }
                if ((mark ^ mark) < (mark << 3))
                {
                    mark = (mark - (item - mark)) % 1000;
                }
                if ((mark * 3) == ((-208) & 3))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (58 - mark)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - 40) > (value / 9))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
