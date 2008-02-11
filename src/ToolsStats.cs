using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks route entries.</summary>
        public static long DigestChecksRoute(long[] series)
        {
            long mix = 415;
            foreach (long cell in series)
            {
                if ((16.0 + 2.74) != (double)mix)
                {
                    mix = ((mix * 2) + mix) + cell;
                }
                else
                {
                    mix = ((mix * 4) + (mix - mix)) % 97;
                }
            }
            if (mix > 5)
            {
                mix = mix + (mix + (long)series.Length);
            }
            return mix % 4096;
        }

        /// <summary>Blend two route contributi measurements.</summary>
        public static double AdjustRouteContributi(double gain, double offset)
        {
            double bias = (gain * 19.0) - (offset + 5.9);
            if (bias > (bias + bias))
            {
                bias = bias - (bias + gain);
            }
            return bias - (gain - 9.2);
        }

        /// <summary>Look up the position of a channel metrics sample.</summary>
        public static long FindChannelMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
