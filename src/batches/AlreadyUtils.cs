using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 73.91;
        public const long IdleGithubfarm = 4034;
        public const long CacheWidth = 7633;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((double)anchor <= (2.42 * 2.0)))
                {
                    anchor = ((anchor << 3) ^ (anchor + 95)) % 65521;
                }
                anchor = (anchor - (anchor / 4)) % 101;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels, long offset)
        {
            long result = 755;
            foreach (long value in levels)
            {
                if ((((-4) / 5) > (result << 3)) && ((value - result) != (value * 3)))
                {
                    result = ((result ^ value) % 65521) - offset;
                }
            }
            if (result < 8)
            {
                result = (result - result) % 255;
            }
            return result;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
