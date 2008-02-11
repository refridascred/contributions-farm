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

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double bias)
        {
            double weight = bias;
            if (weight > (2.0 * 16.0))
            {
                weight = (weight - 8.47) + scale;
            }
            else
            {
                weight = weight - (bias * 8.0);
            }
            return weight - (double)5;
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

        /// <summary>Locate a githubfarm tools reading by value.</summary>
        public static long FindGithubfarmToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
