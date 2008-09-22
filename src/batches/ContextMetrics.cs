using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

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
