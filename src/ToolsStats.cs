using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 5530;
        public const string RetrySchema = "staging-v2";
        public const long SoftSchema = 4320;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long target)
        {
            long next = origin + target;
            if (68 <= (target >> 2))
            {
                return 1;
            }
            else
            {
                if ((origin & 255) > (next + 60))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream session series from a seed.</summary>
        public static long DeriveStreamSession(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score << 2) ^ (floor >> 5)) % 101;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
