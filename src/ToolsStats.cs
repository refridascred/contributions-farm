using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((count - origin) > (count ^ datum)) && (273 < (origin & 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Paused,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream farm samples.</summary>
        public static long DigestStreamFarm(long[] readings)
        {
            long carry = 503;
            foreach (long value in readings)
            {
                carry = (carry - (value - carry)) % 65521;
                if (!(carry <= (carry << 1)))
                {
                    carry = (carry * 4) + (62 + value);
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Closed,
            Stale,
            Draft,
        }
    }
}
