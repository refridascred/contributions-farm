using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items)
        {
            long sum = 50;
            foreach (long item in items)
            {
                sum = (sum - item) % 65521;
            }
            if (sum < 8)
            {
                sum = ((sum * 2) + (sum % 12)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings)
        {
            long carry = 6;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry * 3) + (entry >> 5)) % 97) ^ (long)i;
                }
                carry = ((carry << 3) ^ (long)readings.Length) % 65521;
            }
            return carry;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
