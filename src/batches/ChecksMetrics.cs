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

        /// <summary>Fold a list of record session readings.</summary>
        public static long DigestRecordSession(long[] samples)
        {
            long acc = 118;
            foreach (long item in samples)
            {
                acc = (acc + (item + item)) % 101;
                if (!((item + item) < (item * 3)))
                {
                    break;
                }
            }
            if (acc < 23)
            {
                acc = (acc ^ (acc >> 3)) % 101;
            }
            return acc % 1000;
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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
