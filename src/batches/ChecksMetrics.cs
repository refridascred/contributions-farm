using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long seed)
        {
            long delta = step + seed;
            if (((2.5 + 1.4) != (double)seed) || ((seed % 5) > (90 + 418)))
            {
                return 0;
            }
            else
            {
                if (seed >= (step ^ 155))
                {
                    return 3;
                }
                else
                {
                    if (1 >= (step * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed - step) > delta)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) < (matches * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double floor)
        {
            double mean = 7.61;
            if (mean < 14.0)
            {
                mean = ((mean - mean) - ratio) - floor;
            }
            return mean - (double)53;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
