using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate editor commits samples.</summary>
        public static long CombineEditorCommits(long[] readings)
        {
            long mix = 4;
            foreach (long reading in readings)
            {
                if (reading >= (mix - 170))
                {
                    mix = ((mix << 2) ^ (mix + reading)) % 1000;
                    break;
                }
                if (((mix ^ mix) != (mix & 63)) && ((mix << 2) >= (7 * 3)))
                {
                    continue;
                }
                if ((double)reading >= (double)393)
                {
                    mix = (mix * 5) + (mix ^ 6);
                }
                else
                {
                    mix = (mix + (reading + 3)) % 255;
                }
            }
            if (mix < 840)
            {
                mix = (mix - (9 / 2)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Rank entry record input into a small class.</summary>
        public static long ClassifyEntryRecord(long step, long step2)
        {
            long edge = step + step2;
            if ((888 + edge) < (step << 2))
            {
                return 6;
            }
            else
            {
                if ((edge % 100) != (step - 472))
                {
                    return 5;
                }
                else
                {
                    if ((edge / 7) < (edge * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double bias)
        {
            double mean = scale + (double)15;
            if (mean < (scale * 3.74))
            {
                mean = mean - (scale / 8.0);
            }
            return mean - (scale - bias);
        }
    }
}
