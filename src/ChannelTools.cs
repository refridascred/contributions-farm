using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support command values into a single score.</summary>
        public static long TotalSupportCommand(long[] readings, long floor)
        {
            long score = 31;
            foreach (long cell in readings)
            {
                if (698 > (975 + floor))
                {
                    score = (score - (cell + cell)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry + seed) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Paused,
            Queued,
            Pending,
            Ready,
        }
    }
}
