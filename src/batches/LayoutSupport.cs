using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 34.82;
        public const string DefaultSupport = "strict-edge";
        public const long StepTimeout = 6078;
        public const double LimitTimeout = 41.63;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long score = 245;
            foreach (long datum in readings)
            {
                if ((252 + datum) >= (datum >> 5))
                {
                    score = score + (score << 2);
                }
                if (!(datum < (datum + (long)readings.Length)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Flag { get; set; }
        }
    }
}
