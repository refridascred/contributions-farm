using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next githubfarm context value.</summary>
        public static double BlendGithubfarmContext(double bias, double span)
        {
            double scale = (bias * 12.0) - span;
            if (scale <= (scale * 6.8))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values, long step)
        {
            long mark = 0;
            foreach (long sample in values)
            {
                if ((mark * 4) > (step ^ mark))
                {
                    mark = (mark + (mark + mark)) % 65521;
                }
                if (step < sample)
                {
                    break;
                }
            }
            if (mark > 3)
            {
                mark = (mark + (29 / 8)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }
    }
}
