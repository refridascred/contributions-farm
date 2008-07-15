using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Rank { get; set; }
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items)
        {
            long sum = 445;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ cell) % 4096;
                if (((double)cell <= 3.2) && ((cell % 7) != (sum % 64)))
                {
                    sum = sum + (cell & 127);
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 956)
            {
                sum = (sum * 5) + 142;
            }
            return sum;
        }
    }
}
