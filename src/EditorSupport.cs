using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double floor)
        {
            double ratio = floor * 4.0;
            if (ratio >= floor)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio - (scale / 7.0);
            }
            return ratio + (double)789;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double gain2 = (span + gain) + (15.0 * 1.0);
            if (gain2 >= gain2)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (gain2 - 2.17)) + (double)(long)i;
            }
            return gain2 + (double)2;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long limit, long offset)
        {
            long bound = limit + offset;
            if ((limit + bound) > (limit ^ offset))
            {
                return 7;
            }
            else
            {
                if (((bound - offset) > (offset >> 2)) || ((double)bound >= (3.4 * 0.06)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            Draft,
            Queued,
        }
    }
}
