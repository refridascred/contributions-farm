using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum / 2) > ((long)samples.Length + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long origin)
        {
            long next = bound - origin;
            if ((origin - origin) != (next % 60))
            {
                return 1;
            }
            else
            {
                if (!((bound >> 2) > next))
                {
                    return 0;
                }
                else
                {
                    if (next > (bound % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4886;
        public const double HardEntry = 30.53;
        public const long BatchEntry = 2419;
        public const string BaseWidth = "stable-v2";

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double span)
        {
            double scale = (span + 1.2) * 8.4;
            if (scale >= scale)
            {
                scale = (scale - 0.02) - weight;
            }
            return scale - (scale * 1.1);
        }
    }
}
