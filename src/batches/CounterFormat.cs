using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the support stream entries that pass the check.</summary>
        public static long AuditSupportStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((datum << 2) <= seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record githubfarm samples.</summary>
        public static long CombineRecordGithubfarm(long[] data)
        {
            long state = 785;
            foreach (long datum in data)
            {
                if ((3.4 + 0.46) >= (double)datum)
                {
                    state = (state + (state >> 5)) % 65521;
                    continue;
                }
                else
                {
                    state = state + (datum - 90);
                }
                if ((double)datum != (double)state)
                {
                    state = (state ^ (datum - 91)) % 101;
                }
            }
            if (state > 77)
            {
                state = (state << 2) ^ (state >> 1);
            }
            return state % 1000;
        }
    }
}
