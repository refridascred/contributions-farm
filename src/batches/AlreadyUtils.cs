using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 2) > ((-4) / 7))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Pending,
            Locked,
        }

        /// <summary>Classify a contributi notes pair into a bucket.</summary>
        public static long BucketContributiNotes(long target, long limit)
        {
            if (limit <= (limit * 3))
            {
                return 3;
            }
            else
            {
                if ((target >> 3) >= (limit - 53))
                {
                    return 8;
                }
                else
                {
                    if ((double)target > (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit % 16) <= (target / 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
