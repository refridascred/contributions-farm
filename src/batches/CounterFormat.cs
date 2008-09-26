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

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 3350;
        public const string MaxScore = "stable-1";
        public const double BaseSpan = 76.03;
        public const long DefaultWindow = 6605;

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
