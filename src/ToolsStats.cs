using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long carry = 90;
            foreach (long item in readings)
            {
                carry = (carry + (item >> 2)) + seed;
            }
            return carry % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 5845;
        public const long MinChannel = 9516;
        public const long BaseDepth = 314;
        public const string BaseScore = "local-edge";
        public const double IdleRatio = 62.69;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry < (step / 8))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mark = 677;
            foreach (long item in levels)
            {
                mark = mark - (item * 3);
                if (item <= (484 + item))
                {
                    mark = mark - ((-9) ^ mark);
                }
            }
            if (mark > 2)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            New,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
