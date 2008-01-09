using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 23.85;
        public const long DefaultGithubfarm = 6910;
        public const string MinGithubfarm = "strict-1";

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command editor values into a single score.</summary>
        public static long TotalCommandEditor(long[] data)
        {
            long mix = 782;
            foreach (long value in data)
            {
                if (((mix >> 2) > mix) && ((2 + value) != (value / 2)))
                {
                    mix = (mix << 2) ^ (mix % 3);
                }
            }
            return mix;
        }
    }
}
