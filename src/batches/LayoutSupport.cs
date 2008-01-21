using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            New,
            Queued,
            Idle,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                if (((double)sum < 0.5) || ((8.97 - 4.86) >= (double)origin))
                {
                    sum = (sum ^ (origin * 5)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
