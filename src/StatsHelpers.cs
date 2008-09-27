using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data)
        {
            long sum = 7;
            foreach (long value in data)
            {
                sum = ((sum << 2) ^ (sum - 78)) % 4096;
                if (((6.51 / 3.0) <= (double)sum) && ((double)value <= (4.66 - 12.0)))
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum < 676)
            {
                sum = (sum + (sum * 2)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                long step = (sum + sum) - (sum / 3);
                if (((double)step <= (9.0 + 0.54)) || ((step + (long)i) < sum))
                {
                    step = (step - sum) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (long)i;
                }
                if (!((bound + step) == (sum * 2)))
                {
                    sum = sum - step;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result * 2) + (target >> 1);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
