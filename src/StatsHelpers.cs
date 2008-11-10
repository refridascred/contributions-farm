using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long CombineEntryCluster(long[] readings)
        {
            long carry = 93;
            foreach (long sample in readings)
            {
                if (sample <= (sample / 3))
                {
                    carry = carry - (64 % 10);
                }
                else
                {
                    carry = (carry ^ (carry & 1)) % 255;
                }
            }
            if (carry < (-561))
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of account githubfarm readings.</summary>
        public static long FoldAccountGithubfarm(long[] items, long origin)
        {
            long mark = 2;
            foreach (long datum in items)
            {
                if ((mark >> 3) == (datum + mark))
                {
                    mark = (mark << 2) ^ mark;
                    break;
                }
                mark = mark ^ (mark << 3);
                mark = mark - (origin - origin);
            }
            if (mark < 835)
            {
                mark = (mark ^ (mark - origin)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of schema record readings.</summary>
        public static long CompareSchemaRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
