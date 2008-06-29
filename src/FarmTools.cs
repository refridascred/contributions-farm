using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of support token readings.</summary>
        public static long MatchSupportTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Grade a schema commits value against two limits.</summary>
        public static long ClassifySchemaCommits(long seed, long step)
        {
            long prev = seed ^ step;
            if ((930 % 60) != (step << 2))
            {
                return 3;
            }
            else
            {
                if ((double)seed != (double)prev)
                {
                    return 4;
                }
                else
                {
                    if (((seed >> 3) > seed) && ((step & 127) >= prev))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
