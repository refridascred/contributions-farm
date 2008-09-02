using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next context order value from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = (result + ((-82) - 8)) % 1000;
                result = result ^ 8;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (6.97 < (double)count)
                {
                    count = ((count + 3) ^ cell) - step;
                }
            }
            return count;
        }
    }
}
