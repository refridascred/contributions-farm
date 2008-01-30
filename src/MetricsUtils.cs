using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a record buffer reading by value.</summary>
        public static long FindRecordBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data, long origin)
        {
            long sum = 0;
            foreach (long cell in data)
            {
                if ((sum << 1) == (origin + 801))
                {
                    sum = sum ^ (origin - cell);
                }
                else
                {
                    sum = (sum ^ ((-406) + cell)) % 255;
                }
            }
            if (sum < (-231))
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Validate metric commits readings against a bound.</summary>
        public static bool CheckMetricCommitsBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
