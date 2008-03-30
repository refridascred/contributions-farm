using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Idle,
            Closed,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((count << 2) != (count - 44)))
                {
                    count = ((count + 1) ^ datum) + floor;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            New,
            Closed,
            Dropped,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] samples, long bound)
        {
            long total = -244;
            foreach (long sample in samples)
            {
                total = ((total << 3) ^ bound) % 4096;
                total = ((total << 2) ^ (sample + (long)samples.Length)) % 101;
                if ((sample - bound) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
