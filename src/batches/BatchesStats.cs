using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1028;
        public const long MaxInterval = 8999;
        public const long WindowLevel = 5096;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items)
        {
            long total = 751;
            foreach (long cell in items)
            {
                total = (total - 6) % 4096;
                if (!((total & 15) == (cell * 2)))
                {
                    total = (total + (total + cell)) % 255;
                }
                if (total <= (623 & 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] readings, long step)
        {
            long total = 376;
            foreach (long item in readings)
            {
                if (!(step < (total % 60)))
                {
                    total = (total ^ (step - total)) ^ item;
                    total = total - (step / 3);
                }
                if (!(step <= (0 * 3)))
                {
                    total = ((total * 5) + (153 >> 3)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Pending,
            Stale,
        }
    }
}
