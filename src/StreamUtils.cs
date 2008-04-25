using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Mode { get; set; }
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] values, long target)
        {
            long result = 827;
            foreach (long value in values)
            {
                result = (((result + result) % 97) - value) - target;
            }
            return result % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long WeighGithubfarmToken(long[] samples, long floor)
        {
            long mark = 19;
            foreach (long item in samples)
            {
                if (!((item - floor) == (item + floor)))
                {
                    mark = (mark - (floor * 4)) % 101;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 9)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
