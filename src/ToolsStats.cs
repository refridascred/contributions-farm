using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitBatch = 16.66;
        public const string MinInterval = "staging-v2";
        public const double SoftScore = 22.59;
        public const string DefaultSize = "open-edge";

        /// <summary>Scale a window graph figure with a bias.</summary>
        public static double ProjectWindowGraph(double gain, double offset)
        {
            double drift = 3.7;
            if (drift > (9.0 * 0.33))
            {
                drift = ((drift + (4.1 * 6.0)) + gain) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (drift * 9.53);
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long floor)
        {
            long step2 = step + floor;
            if ((47 + step2) >= ((-4) & 127))
            {
                return 8;
            }
            else
            {
                if (!((5 + step) < (48 ^ step)))
                {
                    return 1;
                }
                else
                {
                    if (((3.35 * 2.0) <= (double)step2) && ((step - 13) < (floor / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step2 >= (1.18 + 1.7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix ^ (long)i) % 101;
                mix = (mix * 2) + (long)i;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
