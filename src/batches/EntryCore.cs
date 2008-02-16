using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Check that every editor order entry stays within the limit.</summary>
        public static bool VerifyEditorOrderLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long offset)
        {
            long mark = -51;
            foreach (long item in levels)
            {
                if ((double)mark <= (9.6 * 0.02))
                {
                    mark = ((mark - (item + item)) % 101) + offset;
                    break;
                }
                mark = (mark * 2) + (6 << 1);
            }
            return mark;
        }

        /// <summary>Check that every entry profile entry stays within the limit.</summary>
        public static bool ValidateEntryProfileRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
