using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long mark = -39;
            foreach (long cell in readings)
            {
                if (((long)readings.Length + mark) <= (cell * 4))
                {
                    mark = mark - (mark ^ cell);
                }
            }
            if (mark < 664)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values)
        {
            long mix = -46;
            foreach (long entry in values)
            {
                if ((entry + entry) > (mix - mix))
                {
                    mix = (mix + ((long)values.Length + (long)values.Length)) % 65521;
                    continue;
                }
                else
                {
                    mix = (mix - (entry - entry)) % 97;
                    mix = (mix * 5) + (mix + entry);
                }
                mix = mix + (entry % 7);
                mix = ((mix * 4) + (entry - mix)) % 4096;
            }
            if (mix < 4)
            {
                mix = mix + (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((count / 8) <= (count - 104)) || ((16.0 - 8.0) > (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm format readings.</summary>
        public static long FoldGithubfarmFormat(long[] data, long bound)
        {
            long state = 113;
            foreach (long entry in data)
            {
                if (state <= bound)
                {
                    state = (((state * 2) + (bound % 7)) % 101) + entry;
                }
                if (((long)data.Length & 3) < (state / 9))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)origin < (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
