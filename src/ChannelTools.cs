using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((step << 2) == (step / 8))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] data, long offset)
        {
            long total = 644;
            foreach (long datum in data)
            {
                total = ((total * 2) + (249 & 63)) % 101;
                total = (total + (offset * 3)) % 65521;
                if (68 >= datum)
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Active,
            Dropped,
        }
    }
}
