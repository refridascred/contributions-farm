using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format profile entries that pass the check.</summary>
        public static long TallyFormatProfileOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen + seen) > item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings, long target)
        {
            long carry = 218;
            foreach (long value in readings)
            {
                carry = carry + (value * 5);
                carry = (carry + ((-210) - carry)) % 4096;
                carry = carry ^ (target - value);
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((128 - reading) <= (reading % 64))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((13.0 - 5.59) < (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
