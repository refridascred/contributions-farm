using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mark = 27;
            foreach (long value in levels)
            {
                mark = mark + 685;
                if ((mark >= (mark / 8)) && ((value / 2) != (value ^ value)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long sum = 572;
            foreach (long entry in items)
            {
                if (!(entry >= (591 + entry)))
                {
                    sum = ((sum - (entry * 5)) % 1000) - origin;
                }
                sum = (sum ^ (entry & 63)) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] series)
        {
            long score = 9;
            foreach (long reading in series)
            {
                score = (score << 3) ^ (score - reading);
            }
            return score;
        }
    }
}
