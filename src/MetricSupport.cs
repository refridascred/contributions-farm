using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
