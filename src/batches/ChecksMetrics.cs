using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFactor = 6736;
        public const double SoftCount = 56.31;
        public const long DefaultFarm = 7167;

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] data)
        {
            long state = -633;
            foreach (long entry in data)
            {
                state = (((state << 2) ^ (state ^ state)) % 255) - entry;
            }
            if (state > (-877))
            {
                state = ((state << 2) ^ (state ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
