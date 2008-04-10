using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Retry,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Audit editor batch readings against a rule.</summary>
        public static long AuditEditorBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum <= count)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            if (2 > (limit + step))
            {
                return 6;
            }
            else
            {
                if (((limit / 5) < (limit << 2)) && ((limit / 5) != (limit + step)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
