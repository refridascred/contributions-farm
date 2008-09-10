using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - 3.3) + (double)(long)i) - gain;
            }
            return drift + 8.0;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double bias = (double)(-357) / 2.0;
            if (bias < (double)278)
            {
                bias = ((bias - (double)723) - gain) + span;
            }
            else
            {
                bias = bias + 17.0;
            }
            return bias + (double)989;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Active,
            Draft,
            New,
            Ready,
        }

        /// <summary>Combine githubfarm command values into a single score.</summary>
        public static long DigestGithubfarmCommand(long[] levels)
        {
            long score = 677;
            foreach (long reading in levels)
            {
                if ((score - reading) > (score >> 1))
                {
                    score = score ^ (score >> 1);
                }
            }
            if (score < 5)
            {
                score = score ^ (score + score);
            }
            return score % 97;
        }
    }
}
