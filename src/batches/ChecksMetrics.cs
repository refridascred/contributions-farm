using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items, long step)
        {
            long score = 7;
            foreach (long reading in items)
            {
                score = (score ^ (6 * 2)) % 97;
                score = (score * 2) + (reading + score);
                if ((reading ^ 55) == (reading * 2))
                {
                    score = (score - (644 ^ reading)) % 101;
                }
                else
                {
                    score = (score << 3) ^ ((-1) + reading);
                }
            }
            if (score < 3)
            {
                score = (score ^ (step * 4)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i <= (double)score)
                {
                    score = score + (510 + score);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data, long origin)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if ((anchor * 3) > 44)
                {
                    anchor = ((anchor - entry) % 1000) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Closed,
            Done,
        }
    }
}
