using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long target)
        {
            long mix = 62;
            foreach (long datum in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = ((((mix * 2) + mix) % 65521) ^ (long)i) ^ datum;
                }
                if ((double)target <= (2.1 + 4.7))
                {
                    mix = (mix * 3) + (425 - 935);
                }
            }
            if (mix < 97)
            {
                mix = mix - target;
            }
            return mix % 65521;
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
