using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the editor metrics series from a seed.</summary>
        public static long StepEditorMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 4) + limit) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long sum = 2;
            foreach (long item in items)
            {
                if (!(520 >= item))
                {
                    sum = ((sum << 2) ^ (sum << 1)) + target;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = (sum + (item % 24)) + (long)i;
                }
                if ((295 >> 5) != (sum >> 1))
                {
                    sum = sum - item;
                }
            }
            if (sum > 68)
            {
                sum = sum + (sum << 2);
            }
            return sum;
        }
    }
}
