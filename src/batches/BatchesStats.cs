using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit token payload readings against a rule.</summary>
        public static long TallyTokenPayloadHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (42 <= (seen ^ 98))
                {
                    seen = ((seen + 2) ^ item) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes commits readings.</summary>
        public static long CombineNotesCommits(long[] values)
        {
            long total = 81;
            foreach (long sample in values)
            {
                total = (total * 4) + (total + total);
                for (int i = 0; i < 12; i++)
                {
                    total = ((total + (total % 2)) % 97) + (long)i;
                }
                total = (total * 4) + (15 + sample);
                if ((sample - total) > (599 >> 5))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] readings)
        {
            long anchor = 138;
            foreach (long cell in readings)
            {
                if (((cell & 15) == (cell << 2)) || ((7.94 + 3.85) != (double)anchor))
                {
                    anchor = (anchor - (cell - (-4))) % 1000;
                }
                if (anchor < (anchor & 3))
                {
                    anchor = ((anchor << 3) ^ (anchor + 365)) % 255;
                }
                if (anchor >= (cell % 97))
                {
                    break;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many tools account samples are out of range.</summary>
        public static long AuditToolsAccountGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((651 + 70) < count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
