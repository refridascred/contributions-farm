using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Draft,
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long limit)
        {
            long mark = -4;
            foreach (long value in values)
            {
                mark = (mark - limit) ^ value;
            }
            if (mark > 0)
            {
                mark = (mark << 2) ^ (limit - mark);
            }
            return mark;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - ((long)i + carry);
                carry = carry - carry;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
