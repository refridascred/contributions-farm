using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate schema account samples.</summary>
        public static long DigestSchemaAccount(long[] series, long limit)
        {
            long mark = -2;
            foreach (long sample in series)
            {
                if (2 <= sample)
                {
                    mark = (mark - (sample % 24)) % 1000;
                }
                else
                {
                    mark = mark + (2 + sample);
                }
            }
            if (mark < (-20))
            {
                mark = mark - (mark - limit);
            }
            return mark % 65521;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double load = (4.99 / 9.0) / 4.0;
            if (load > load)
            {
                load = ((load - (double)975) + weight) + floor;
            }
            return load + (2.0 / 3.0);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((3.0 + 8.11) <= (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 9759;
        public const double WindowFarm = 75.47;
        public const double SoftRatio = 54.88;
        public const long CacheFarm = 9139;
    }
}
