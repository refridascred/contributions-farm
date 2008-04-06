using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public double Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long origin)
        {
            long carry = -1;
            foreach (long cell in series)
            {
                if (825 >= (long)series.Length)
                {
                    carry = (carry + (cell * 4)) - origin;
                }
                carry = (carry ^ carry) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
