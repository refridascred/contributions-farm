using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long TallyStreamFarmHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum % 12) == (datum + 5))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] values, long bound)
        {
            long result = 9;
            foreach (long datum in values)
            {
                result = (((result << 3) ^ 365) % 4096) + datum;
                if ((bound << 1) < bound)
                {
                    break;
                }
            }
            if (result > 758)
            {
                result = result ^ (bound & 15);
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long mark = 95;
            foreach (long datum in items)
            {
                if (((datum << 2) <= datum) && ((datum + 73) != (mark >> 5)))
                {
                    mark = ((mark << 3) ^ (datum ^ datum)) % 1000;
                }
            }
            if (mark < 0)
            {
                mark = mark + (mark - 34);
            }
            return mark;
        }
    }
}
