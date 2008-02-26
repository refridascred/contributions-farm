using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine entry format values into a single score.</summary>
        public static long ScoreEntryFormat(long[] series)
        {
            long mark = -5;
            foreach (long cell in series)
            {
                mark = (mark - (97 + cell)) % 4096;
                if (mark <= (cell & 63))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long target)
        {
            long mix = 9;
            foreach (long sample in readings)
            {
                mix = (mix - (sample - target)) % 1000;
                if ((sample - sample) < mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading + 984) > (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
