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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally < (datum & 31)) || ((tally < (83 + 48)) || ((double)tally >= (7.61 * 4.0))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
