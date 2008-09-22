using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheFactor = "primary-edge";
        public const string WindowCount = "local-edge";
        public const long WindowChecks = 7217;

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double gain = 16.0;
            if (gain > (gain + ratio))
            {
                gain = (gain + (double)12) - floor;
            }
            else
            {
                gain = gain + 11.0;
            }
            return gain - (double)(-86);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item - 0) < (item << 2)) && (((item * 4) < (item * 5)) || ((item << 2) < (seen & 127))))
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = state ^ (long)i;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state << 3) ^ ((long)i2 ^ origin)) % 4096;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
