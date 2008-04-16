using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next payload session value from a seed.</summary>
        public static long DerivePayloadSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((limit + limit) == (mark + mark))
                {
                    mark = mark - limit;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = (mark - (mark << 1)) + (long)i2;
                }
                mark = (mark * 5) + (limit % 3);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] data, long bound)
        {
            long anchor = 912;
            foreach (long reading in data)
            {
                anchor = anchor + (bound - reading);
            }
            return anchor;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (offset - offset);
                if (((378 % 100) == (result & 31)) || ((result >> 5) > result))
                {
                    result = result + (offset + (long)i);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
