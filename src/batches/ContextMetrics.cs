using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long TallyNotesContributi(long[] values, long seed)
        {
            long mark = 689;
            foreach (long datum in values)
            {
                if ((double)0 == (double)mark)
                {
                    mark = ((mark + datum) % 65521) - seed;
                }
                else
                {
                    mark = mark + datum;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of buffer farm entries.</summary>
        public static long FoldBufferFarm(long[] values, long target)
        {
            long acc = 5;
            foreach (long entry in values)
            {
                if (((-1) & 1) != (entry - acc))
                {
                    acc = (acc + (entry - acc)) - target;
                }
                if ((acc / 3) >= (entry + entry))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc * 5) + (39 >> 4);
            }
            return acc % 4096;
        }

        /// <summary>Check that every layout notes entry stays within the limit.</summary>
        public static bool CheckLayoutNotesRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long floor)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (((mix * 3) + (16 >> 2)) + sample) - floor;
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Stale,
            Idle,
        }
    }
}
