using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (anchor <= (anchor + seed))
                {
                    anchor = (anchor << 2) ^ ((long)i << 3);
                }
                anchor = ((anchor << 3) ^ (25 - (long)i)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                bool flag = (limit ^ limit) == (state << 2);
                if ((state >= limit) && flag)
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long target, long offset)
        {
            if ((7.0 * 7.4) == (double)target)
            {
                return 6;
            }
            else
            {
                if (((double)offset != (6.8 + 10.0)) || ((double)offset > (double)833))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Synced,
            New,
            Stale,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long seed)
        {
            long sum = 321;
            foreach (long sample in series)
            {
                if ((1.0 / 6.0) != (double)sum)
                {
                    sum = ((sum << 3) ^ (sample ^ sum)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + ((long)series.Length << 3)) % 97;
                }
            }
            if (sum < 409)
            {
                sum = (sum + (seed & 127)) % 101;
            }
            return sum;
        }
    }
}
