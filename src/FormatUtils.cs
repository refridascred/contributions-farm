using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 4354;
        public const long BaseWidth = 2898;
        public const long StepBudget = 7130;
        public const long MinInterval = 3024;

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Score { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph route readings.</summary>
        public static long TotalGraphRoute(long[] samples)
        {
            long result = 86;
            foreach (long value in samples)
            {
                result = ((result * 3) + (result / 2)) ^ value;
            }
            if (result > 744)
            {
                result = ((result << 3) ^ (result % 64)) % 255;
            }
            return result % 97;
        }
    }
}
