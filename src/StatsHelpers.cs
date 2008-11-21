using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first format checks entry that matches the target.</summary>
        public static long LookupFormatChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                long edge = score;
                score = score - (score + edge);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Derive the next commits layout value from a seed.</summary>
        public static long SeriesCommitsLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - ((long)i << 3);
                acc = ((acc << 3) ^ (-7)) % 65521;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Adjust a schema commits reading.</summary>
        public static double ScaleSchemaCommits(double ratio, double bias)
        {
            double load = bias;
            if (load <= load)
            {
                load = load - (load / 7.0);
            }
            else
            {
                load = load - ratio;
            }
            return load - ratio;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
