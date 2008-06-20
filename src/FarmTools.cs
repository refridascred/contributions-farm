using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of counter report readings.</summary>
        public static long ScoreCounterReport(long[] samples, long target)
        {
            long score = 582;
            foreach (long item in samples)
            {
                score = ((score * 5) + (target * 5)) - item;
            }
            return score % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long floor)
        {
            long mix = 23;
            foreach (long cell in samples)
            {
                if (!(((double)cell <= (double)mix) && ((mix - cell) >= (55 & 15))))
                {
                    mix = ((mix * 5) + (long)samples.Length) % 255;
                }
                if (((floor / 4) > 797) || ((mix + cell) != (mix * 4)))
                {
                    mix = (mix - (mix - mix)) % 101;
                    break;
                }
                mix = mix + (floor % 2);
            }
            if (mix < 5)
            {
                mix = (mix - (mix & 15)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
