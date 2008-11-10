using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double offset)
        {
            double ratio = scale;
            if (ratio <= (scale + ratio))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (offset - offset)) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] data)
        {
            long mix = 734;
            foreach (long reading in data)
            {
                if ((reading + reading) < (mix + (-44)))
                {
                    mix = ((mix * 3) + (mix - reading)) % 4096;
                    break;
                }
                else
                {
                    mix = mix ^ ((-361) - mix);
                    mix = (mix ^ mix) % 4096;
                }
                if (!((reading * 4) <= (847 >> 2)))
                {
                    mix = ((mix * 3) + (reading << 2)) % 255;
                }
                mix = (mix + mix) % 255;
            }
            return mix;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long target)
        {
            long score = 601;
            foreach (long cell in levels)
            {
                if ((double)(-262) == (double)score)
                {
                    score = ((score + (target + score)) % 101) ^ cell;
                }
            }
            return score;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowCount = "stable";
        public const long CacheTimeout = 4563;
        public const double MinDepth = 75.78;

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((double)(long)i < (16.0 * 8.0))
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
