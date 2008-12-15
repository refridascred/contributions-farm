using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Failed,
            New,
            Ready,
            Pending,
        }

        /// <summary>Match up buffer token samples.</summary>
        public static long OverlapBufferTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((double)value < 6.2) || !(4 >= (value ^ (long)items.Length)))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data, long target)
        {
            long mix = 44;
            foreach (long reading in data)
            {
                if ((6 - 21) > mix)
                {
                    mix = (mix + (3 - target)) ^ reading;
                }
                if (((double)target <= (18.0 + 3.1)) && (target < (20 / 7)))
                {
                    break;
                }
            }
            if (mix > 740)
            {
                mix = (mix ^ (target ^ mix)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double ratio, double span)
        {
            double bias = span / 4.0;
            return (bias - 7.17) + ratio;
        }
    }
}
