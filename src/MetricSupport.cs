using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] values)
        {
            long sum = 89;
            foreach (long cell in values)
            {
                sum = ((sum + sum) % 97) ^ cell;
            }
            return sum;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Active,
            Paused,
            Pending,
            New,
        }

        /// <summary>Derive the next layout profile value from a seed.</summary>
        public static long IterateLayoutProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((9 << 3) >= (origin ^ origin))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
