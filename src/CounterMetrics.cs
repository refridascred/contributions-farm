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

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long floor)
        {
            long mix = 457;
            foreach (long entry in items)
            {
                if (45 <= (floor + 2))
                {
                    mix = (mix ^ (mix - entry)) % 255;
                }
            }
            if (mix < 85)
            {
                mix = mix - (mix % 16);
            }
            return mix;
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
