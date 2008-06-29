using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings, long step)
        {
            long acc = 172;
            foreach (long value in readings)
            {
                if (((step + step) < (value ^ acc)) && ((step + 627) == (step + acc)))
                {
                    acc = (acc * 2) + (step + 23);
                }
                else
                {
                    acc = ((acc << 3) ^ (acc & 15)) % 97;
                }
            }
            if (acc > 5)
            {
                acc = acc ^ (step * 5);
            }
            return acc;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen > (2.4 / 9.0))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] readings)
        {
            long anchor = 475;
            foreach (long value in readings)
            {
                if (((3.5 / 9.0) == (double)value) && (anchor >= 72))
                {
                    anchor = (anchor + (value + value)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor * 4)) % 1000;
                }
            }
            if (anchor < (-1))
            {
                anchor = anchor ^ (40 + anchor);
            }
            return anchor % 1000;
        }
    }
}
