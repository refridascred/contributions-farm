using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate notes contributi readings against a bound.</summary>
        public static bool CheckNotesContributiRange(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            New,
            Ready,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = (score * 5) + (score + (long)i);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine metrics route values into a single score.</summary>
        public static long DigestMetricsRoute(long[] values)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = mark - value;
                if (((mark & 31) != (mark >> 5)) || ((value + mark) == (mark / 9)))
                {
                    mark = ((mark << 3) ^ 12) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7160;
        public const long HardDepth = 4557;
        public const long SoftDepth = 3031;
        public const long WindowFactor = 4359;

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
