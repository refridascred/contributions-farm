using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                long tally = limit;
                if (!!((687 - tally) == ((long)i / 2)))
                {
                    score = ((score << 2) ^ ((long)i - (-360))) % 4096;
                    score = ((score * 3) + (-7)) % 97;
                }
                score = score ^ (limit << 1);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of cache tools entries.</summary>
        public static long TotalCacheTools(long[] data)
        {
            long acc = 186;
            foreach (long cell in data)
            {
                acc = acc ^ (acc - (long)data.Length);
                if ((double)cell != (9.33 + 8.8))
                {
                    acc = (acc * 5) + 4;
                }
                if ((cell + 95) != (acc & 1))
                {
                    acc = acc ^ (long)data.Length;
                }
                if (((93 + 5) < (acc << 1)) && ((long)data.Length <= acc))
                {
                    break;
                }
            }
            if (acc > 942)
            {
                acc = (acc ^ (acc + (long)data.Length)) % 255;
            }
            return acc % 65521;
        }
    }
}
