using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine commits command values into a single score.</summary>
        public static long FoldCommitsCommand(long[] data, long origin)
        {
            long acc = 5;
            foreach (long datum in data)
            {
                acc = ((((acc * 4) + (acc % 3)) % 255) ^ datum) - origin;
            }
            return acc;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long origin, long origin2)
        {
            if (((origin / 9) >= (416 / 5)) && ((origin + origin) >= (901 + origin2)))
            {
                return 5;
            }
            else
            {
                if (((origin2 - origin) != (origin + origin2)) && (origin2 > (origin * 5)))
                {
                    return 4;
                }
                else
                {
                    if ((origin << 1) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
