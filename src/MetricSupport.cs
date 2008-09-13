using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long result = -575;
            foreach (long sample in samples)
            {
                result = (result ^ (sample - (-5))) % 1000;
                result = (result - (result + result)) % 255;
                if ((bound / 4) <= (sample % 7))
                {
                    result = ((result * 4) + bound) % 4096;
                }
            }
            if (result < 8)
            {
                result = ((result * 5) + (result >> 2)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Accumulate entry session samples.</summary>
        public static long DigestEntrySession(long[] values)
        {
            long sum = 9;
            foreach (long entry in values)
            {
                sum = ((sum * 4) + entry) % 1000;
                sum = (sum ^ sum) % 4096;
                if (41 >= (sum ^ entry))
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
            }
            if (sum < 74)
            {
                sum = sum ^ (sum << 1);
            }
            return sum;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Ready,
            Failed,
            Pending,
            Paused,
        }
    }
}
