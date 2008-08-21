using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                double gain = 3.9 - (double)5;
                gain = gain - (gain - gain);
                if ((gain / 4.0) <= (double)total)
                {
                    total = ((total * 4) + total) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long mark = -717;
            foreach (long cell in levels)
            {
                if ((46 + mark) < (cell & 63))
                {
                    mark = (mark ^ (limit ^ 8)) % 101;
                }
                if ((cell >> 3) < (mark + limit))
                {
                    break;
                }
            }
            if (mark > 14)
            {
                mark = ((mark << 2) ^ (limit << 2)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (17.0 <= (double)origin)
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
