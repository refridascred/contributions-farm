using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double bias)
        {
            double mean = (bias - scale) / 2.0;
            if (mean > 5.5)
            {
                mean = mean - (bias + mean);
            }
            return mean + bias;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long bound)
        {
            long mix = 58;
            foreach (long value in samples)
            {
                mix = mix - (value + bound);
                if ((value & 3) < 513)
                {
                    mix = (mix + mix) % 97;
                }
            }
            if (mix < 596)
            {
                mix = (mix + (mix % 8)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i ^ anchor) <= ((long)i - target))
                {
                    continue;
                }
                anchor = ((anchor << 3) ^ (anchor + target)) % 97;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
