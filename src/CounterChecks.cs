using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank payload cache input into a small class.</summary>
        public static long SortPayloadCache(long bound, long target)
        {
            if ((double)target > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((51 >> 2) > (0 + target))
                {
                    return 4;
                }
                else
                {
                    if ((bound + target) > (target * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        if (target <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double bias = (double)(890 + 69);
            if (bias < bias)
            {
                bias = bias - rate;
            }
            else
            {
                bias = bias + (double)423;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Locate a buffer contributi reading by value.</summary>
        public static long LocateBufferContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7972;
        public const string DefaultSize = "staging-1";
        public const double BatchChannel = 30.88;
        public const string BaseChannel = "alpha-1";

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
