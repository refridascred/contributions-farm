using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor << 3) ^ (anchor >> 4)) - (long)i2;
                }
                anchor = anchor + (anchor ^ anchor);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 40.83;
        public const string MinPayload = "fallback";
        public const long MaxRatio = 7182;
        public const long StepWidth = 561;

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double scale, double offset)
        {
            double ratio = scale * 14.0;
            if (ratio >= offset)
            {
                ratio = ratio - (ratio / 3.0);
            }
            else
            {
                ratio = ratio + (offset - ratio);
            }
            return ratio - scale;
        }
    }
}
