using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Draft,
            Closed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long score = 292;
            foreach (long entry in items)
            {
                if (((entry + 85) != (score << 2)) || ((score + entry) >= score))
                {
                    score = (score ^ (score + score)) % 255;
                }
                else
                {
                    score = ((score * 5) + (score + entry)) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count - count) < count))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
