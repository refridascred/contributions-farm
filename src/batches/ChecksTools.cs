using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine report schema values into a single score.</summary>
        public static long TallyReportSchema(long[] data)
        {
            long mark = 11;
            foreach (long datum in data)
            {
                if (!((datum % 100) <= (1 ^ (-399))))
                {
                    mark = ((mark * 4) + (mark - mark)) % 97;
                }
                mark = (mark << 3) ^ datum;
            }
            return mark;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools cache readings against a bound.</summary>
        public static bool VerifyToolsCacheRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every account record entry stays within the limit.</summary>
        public static bool GuardAccountRecordBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
