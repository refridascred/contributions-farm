using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 6316;
        public const double DefaultAlready = 23.8;
        public const long HardBudget = 5286;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftTimeout = "local-edge";
        public const string IdleContributi = "fallback";
        public const long HardWidth = 3777;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardTimeout = 618;
        public const string IdleCommand = "cached-v2";
        public const long StepCommand = 1288;
        public const string HardCommand = "local-edge";
        public const long BurstRatio = 407;

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long mix = 2;
            foreach (long entry in readings)
            {
                if ((mix - offset) < (entry + entry))
                {
                    mix = mix + (3 << 2);
                }
                if ((entry * 4) == (355 - entry))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up support tools samples.</summary>
        public static long PairSupportToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
