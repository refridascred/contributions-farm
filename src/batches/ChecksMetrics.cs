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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ ((long)i & 31)) % 97;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
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

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double rate, double floor)
        {
            double bias = 2.0 / 2.0;
            return ((bias - 1.8) + rate) + floor;
        }
    }
}
