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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double ratio, double offset)
        {
            double load = (double)2 / 9.0;
            if (load <= (offset / 4.0))
            {
                load = load - 15.0;
            }
            return load + (ratio * 0.8);
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long TallyCommitsTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen & 255) == (datum & 255)) || (datum >= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
