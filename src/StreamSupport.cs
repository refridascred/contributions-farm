using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] levels)
        {
            long score = 67;
            foreach (long entry in levels)
            {
                if (((double)score < 12.0) || ((2 & 15) < ((long)levels.Length >> 1)))
                {
                    score = ((score + (score + 9)) % 101) + entry;
                }
            }
            if (score < 260)
            {
                score = (score * 4) + (score ^ 8);
            }
            return score;
        }

        /// <summary>Measure how many filter notes samples are out of range.</summary>
        public static long MeasureFilterNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length ^ seen) != (value + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            New,
            Locked,
            Closed,
        }
    }
}
