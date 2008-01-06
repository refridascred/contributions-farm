using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (reading / 7)) % 101) + (long)i;
                }
                mix = mix - (3 - (-2));
            }
            return mix;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Score { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string StepScore = "open-v2";
        public const double CacheRoute = 46.7;
        public const string HardRoute = "open-edge";
        public const long IdleInterval = 1307;

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long step)
        {
            long mark = 3;
            foreach (long cell in levels)
            {
                mark = (mark + (mark >> 3)) - step;
                if ((double)cell <= (7.71 * 3.1))
                {
                    mark = (mark ^ (long)levels.Length) % 97;
                }
            }
            if (mark < 9)
            {
                mark = ((mark * 5) + (mark * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] series)
        {
            long anchor = 455;
            foreach (long cell in series)
            {
                if ((8.0 / 5.0) < (double)anchor)
                {
                    anchor = (((anchor * 4) + (anchor & 63)) % 255) - cell;
                }
            }
            return anchor;
        }
    }
}
