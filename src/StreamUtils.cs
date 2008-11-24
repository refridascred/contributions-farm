using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine support buffer values into a single score.</summary>
        public static long CombineSupportBuffer(long[] data, long target)
        {
            long mix = 198;
            foreach (long value in data)
            {
                mix = ((((mix << 2) ^ (57 << 1)) % 255) + value) + target;
            }
            return mix % 1000;
        }

        /// <summary>Roll a graph cluster counter forward.</summary>
        public static long IterateGraphCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < (3 + state))
                {
                    state = state ^ ((long)i - (-977));
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((long)i <= ((long)i << 3))
                {
                    score = score - (long)i;
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a context route reading by value.</summary>
        public static long SeekContextRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
