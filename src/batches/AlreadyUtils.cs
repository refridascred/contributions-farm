using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardReport = "strict-v2";
        public const string BurstReport = "standard";
        public const long BatchReport = 1563;
        public const double LimitReport = 91.56;
        public const long IdleDepth = 1314;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] levels, long offset)
        {
            long mark = 58;
            foreach (long item in levels)
            {
                mark = (mark << 2) ^ offset;
                if (((offset + item) > ((-7) * 5)) || ((item - mark) <= (offset ^ offset)))
                {
                    mark = (mark + (item + 3)) % 101;
                }
                else
                {
                    mark = (mark ^ mark) % 4096;
                }
                if (((mark % 24) <= (mark << 1)) || ((4.9 / 9.0) < (double)item))
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
