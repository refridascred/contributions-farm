using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a session farm counter forward.</summary>
        public static long SeriesSessionFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i / 3) > (long)i)
                {
                    mix = mix ^ (mix - 261);
                }
                mix = (mix + ((long)i & 127)) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] values)
        {
            long mix = 24;
            foreach (long item in values)
            {
                if (((20.0 * 6.2) <= (double)item) && (((-91) - item) == (item << 2)))
                {
                    mix = (mix << 3) ^ (787 + item);
                }
                else
                {
                    mix = mix - item;
                }
            }
            return mix;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the notes commits entries that pass the check.</summary>
        public static long AuditNotesCommitsHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell <= (tally & 127))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
