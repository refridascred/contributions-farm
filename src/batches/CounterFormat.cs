using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] series)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if ((mark >= (cell >> 4)) && ((double)mark < (18.0 - 9.84)))
                {
                    mark = mark - cell;
                }
            }
            return mark;
        }
    }
}
