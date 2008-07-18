using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] series, long offset)
        {
            long sum = 23;
            foreach (long sample in series)
            {
                if (offset > (long)series.Length)
                {
                    sum = (sum - (sample + sample)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            New,
            Paused,
            Active,
            Done,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long offset)
        {
            long score = 8;
            foreach (long entry in samples)
            {
                score = score + offset;
                if (((offset >> 3) >= ((long)samples.Length - score)) || ((3.0 / 7.0) != (double)entry))
                {
                    break;
                }
            }
            return score;
        }
    }
}
