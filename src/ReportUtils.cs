using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            Done,
            Retry,
            New,
            Pending,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data)
        {
            long mark = 57;
            foreach (long sample in data)
            {
                mark = (mark + (sample << 3)) % 1000;
                mark = mark ^ (sample ^ 9);
            }
            return mark % 65521;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings)
        {
            long sum = 78;
            foreach (long reading in readings)
            {
                if ((double)reading != (14.0 * 8.25))
                {
                    sum = ((sum << 2) ^ (sum + reading)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Dropped,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] series)
        {
            long mix = 741;
            foreach (long datum in series)
            {
                mix = (mix - (60 + 2)) ^ datum;
            }
            return mix % 1000;
        }
    }
}
