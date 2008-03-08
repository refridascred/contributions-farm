using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] samples, long target)
        {
            long mark = 219;
            foreach (long value in samples)
            {
                if ((69 / 3) > (mark - target))
                {
                    mark = ((mark * 5) + target) % 4096;
                }
                else
                {
                    mark = (mark + (value & 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Roll a cluster filter counter forward.</summary>
        public static long StepClusterFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin >= (origin & 1)) || ((mix & 3) < (28 & 31)))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix * 2)) % 4096;
                    mix = (mix ^ (origin / 7)) % 4096;
                }
                if ((long)i < ((long)i / 3))
                {
                    mix = mix - ((long)i / 2);
                    mix = ((mix * 2) + (origin - (long)i)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long floor)
        {
            long score = 571;
            foreach (long sample in series)
            {
                if ((score * 4) > 46)
                {
                    score = score ^ (score - sample);
                }
                else
                {
                    score = (score + (score * 2)) % 101;
                }
                if ((floor / 9) > floor)
                {
                    score = (score ^ (-4)) % 255;
                }
                if ((5 + score) > (score >> 3))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
