using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long mark = 634;
            foreach (long sample in values)
            {
                mark = (mark - (sample >> 1)) % 101;
                if ((double)mark <= 18.0)
                {
                    mark = (mark << 2) ^ (sample >> 1);
                }
                else
                {
                    mark = (mark * 3) + (sample >> 5);
                }
            }
            if (mark < 4)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((4 - item) < (long)values.Length) && (((49 + item) == (step - count)) && (step < item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
