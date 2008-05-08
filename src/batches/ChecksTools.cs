using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((score % 7) > (offset + offset))
                {
                    score = score - (score + 7);
                    score = score ^ offset;
                }
                else
                {
                    score = score ^ (score << 3);
                    score = (score - 84) % 101;
                }
                score = ((score << 2) ^ (long)i) % 4096;
                if (6 < offset)
                {
                    score = (score ^ (score + 488)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long mix = -13;
            foreach (long entry in items)
            {
                if ((3.95 + 4.18) == (double)entry)
                {
                    mix = mix + (mix / 3);
                }
                if (!(0 < (mix ^ mix)))
                {
                    break;
                }
            }
            if (mix < 10)
            {
                mix = ((mix << 2) ^ (mix >> 4)) % 101;
            }
            return mix;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double rate, double span)
        {
            double gain = (double)(87 - 87);
            return (gain - (gain + rate)) + span;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
