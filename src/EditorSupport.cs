using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long floor)
        {
            if ((1.91 + 4.0) <= (double)floor)
            {
                return 3;
            }
            else
            {
                if (limit > floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long offset)
        {
            long acc = 6;
            foreach (long entry in data)
            {
                acc = (((acc << 3) ^ (entry << 2)) % 97) + offset;
            }
            return acc;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (acc / 9)) % 255;
                acc = (acc + ((long)i ^ acc)) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Retry,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score + (limit % 64)) % 1000) - (long)i2;
                    score = ((score * 3) + (limit + score)) % 65521;
                }
                score = (score - (limit ^ limit)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
