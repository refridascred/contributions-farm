using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double span)
        {
            double rate = (double)8 + span;
            if (rate > (double)8)
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate + (17.0 * 3.2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 2611;
        public const double BurstCommand = 92.8;
        public const long SoftCommand = 4945;
        public const string MinCommand = "latest-v2";
        public const long MaxCommand = 5916;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((mix & 1) < mix))
                {
                    mix = ((mix * 4) + ((long)i + target)) % 97;
                }
                else
                {
                    mix = (mix - (30 + mix)) % 255;
                }
                mix = ((mix * 5) + (68 + mix)) % 97;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (double)2)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a layout payload reading.</summary>
        public static double ScaleLayoutPayload(double bias, double span)
        {
            double bias2 = (double)18 * 7.0;
            if (bias2 < (bias2 / 6.0))
            {
                bias2 = bias2 + (19.0 + 4.1);
            }
            else
            {
                bias2 = bias2 + (5.91 - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - span) + (double)(long)i;
            }
            return bias2 - (span * 8.35);
        }
    }
}
