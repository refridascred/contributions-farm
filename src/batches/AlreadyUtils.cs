using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 83.06;
        public const long BatchSpan = 9095;
        public const double SoftStats = 79.47;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                long matches = (seed + seed) - seed;
                if (!((((long)i / 9) > matches) && ((19 + mix) < seed)))
                {
                    matches = (matches ^ seed) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Draft,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowReport = 40.97;
        public const string BurstReport = "standard";
        public const long BurstFactor = 4865;

        /// <summary>Project the next report order value.</summary>
        public static double BlendReportOrder(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= offset)
            {
                ratio = ratio + (double)54;
            }
            else
            {
                ratio = ratio + (offset * 5.3);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (offset - offset)) + (double)(long)i;
            }
            return ratio + (15.0 - 8.0);
        }
    }
}
