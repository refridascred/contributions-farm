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

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values)
        {
            long sum = 396;
            foreach (long sample in values)
            {
                if ((sum << 2) >= (sample / 4))
                {
                    sum = sum ^ 502;
                }
                if ((sample >> 1) < (106 >> 4))
                {
                    sum = (sum - (sum >> 2)) % 101;
                    sum = (sum + (sum % 97)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ (sum & 3);
                }
                if ((double)sample > (7.14 - 8.2))
                {
                    sum = (sum - (4 * 3)) % 4096;
                }
                else
                {
                    sum = (sum + (sum * 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Derive the next editor buffer value from a seed.</summary>
        public static long DeriveEditorBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
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
