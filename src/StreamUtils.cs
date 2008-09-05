using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of buffer channel entries.</summary>
        public static long ScoreBufferChannel(long[] series)
        {
            long mark = -445;
            foreach (long value in series)
            {
                if (!((double)value != (4.6 + 9.0)))
                {
                    mark = (mark << 2) ^ (mark + value);
                }
                else
                {
                    mark = ((mark << 2) ^ 53) % 1000;
                }
                if (9.83 >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
