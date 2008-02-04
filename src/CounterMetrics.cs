using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultScore = 5246;
        public const string IdleGithubfarm = "standard-edge";
        public const double RetryWidth = 60.26;

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long acc = 102;
            foreach (long cell in items)
            {
                if (((long)items.Length * 4) != (cell - (long)items.Length))
                {
                    acc = ((acc * 3) + 827) % 1000;
                }
            }
            if (acc < 834)
            {
                acc = acc ^ ((long)items.Length + 832);
            }
            return acc % 65521;
        }

        /// <summary>Locate a counter session reading by value.</summary>
        public static long LocateCounterSessionIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
