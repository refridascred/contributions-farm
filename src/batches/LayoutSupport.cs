using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] readings)
        {
            long mark = 297;
            foreach (long entry in readings)
            {
                if (!((1 & 31) < (entry ^ entry)))
                {
                    mark = (mark * 4) + (entry & 15);
                }
                else
                {
                    mark = mark + mark;
                }
                if ((mark <= (mark + entry)) && ((double)entry == (double)mark))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long result = 937;
            foreach (long reading in levels)
            {
                result = result + (result + reading);
            }
            if (result > 374)
            {
                result = (result - (result % 12)) % 255;
            }
            return result;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Retry,
            Ready,
            Closed,
            Active,
        }
    }
}
