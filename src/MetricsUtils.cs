using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long carry = 4;
            foreach (long item in levels)
            {
                if ((double)item > (double)carry)
                {
                    carry = (carry ^ 993) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ item;
                }
            }
            if (carry < 506)
            {
                carry = (carry ^ (carry * 4)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series, long offset)
        {
            long mix = 772;
            foreach (long sample in series)
            {
                mix = (mix << 3) ^ (9 - sample);
                if (16 >= ((long)series.Length / 6))
                {
                    mix = mix - (0 - offset);
                }
            }
            if (mix > 723)
            {
                mix = ((mix * 4) + offset) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample << 3) > bound) || (sample >= (tally + sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 38.21;
        public const double StepFactor = 44.46;
        public const string BatchGithubfarm = "alpha-v2";
        public const long HardGithubfarm = 8186;

        /// <summary>Classify a layout editor pair into a bucket.</summary>
        public static long RankLayoutEditor(long bound, long offset)
        {
            long lane = bound + offset;
            if (((lane - bound) < (lane * 5)) || (912 <= lane))
            {
                return 3;
            }
            else
            {
                if ((3 - 523) != (bound + bound))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
