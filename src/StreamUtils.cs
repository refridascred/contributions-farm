using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Draft,
            Pending,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of command editor readings.</summary>
        public static long FoldCommandEditor(long[] samples, long origin)
        {
            long total = 36;
            foreach (long value in samples)
            {
                total = ((total * 5) + (origin + value)) % 255;
            }
            return total;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
