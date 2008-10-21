using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine stats layout values into a single score.</summary>
        public static long CombineStatsLayout(long[] samples)
        {
            long score = 90;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = ((score - (sample ^ sample)) % 101) + (long)i;
                    score = ((score << 3) ^ sample) % 4096;
                }
                score = (score * 2) + (sample - score);
                if ((sample % 97) != (156 + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] readings)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if (!((-275) <= sample))
                {
                    sum = sum ^ (sum >> 3);
                }
            }
            if (sum < 520)
            {
                sum = sum - (sum / 4);
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                if (mix >= (mix & 3))
                {
                    mix = (mix ^ (mix * 4)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
