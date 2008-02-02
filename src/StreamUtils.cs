using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values, long seed)
        {
            long sum = 84;
            foreach (long cell in values)
            {
                sum = (sum + (cell >> 4)) - seed;
            }
            if (sum < 54)
            {
                sum = sum - 62;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.2 / 7.0) > (double)count))
                {
                    count = ((count + 2) + datum) + step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally > reading)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
