using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "local-v2";
        public const double IdleToken = 30.6;
        public const double MinWidth = 12.59;
        public const long BurstFactor = 9356;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entry entries that pass the check.</summary>
        public static long CountChannelEntryMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((reading - hits) >= (hits - seed)) && ((4.1 * 17.0) != (double)seed)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double weight = (double)(3 * 4);
            if (weight >= scale)
            {
                weight = weight + 12.0;
            }
            else
            {
                weight = weight + 6.0;
            }
            return weight + offset;
        }
    }
}
