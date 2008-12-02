using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long floor, long target)
        {
            if (((3.99 - 1.2) > (double)floor) || ((double)floor != (9.06 + 6.8)))
            {
                return 4;
            }
            else
            {
                if ((17.0 + 3.52) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((target / 6) < 329)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 5021;
        public const long DefaultLayout = 4512;
        public const double WindowScore = 71.8;

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                if (((-743) & 15) >= cell)
                {
                    score = ((score * 2) + (-965)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = (double)(9 % 24);
            if (drift < gain)
            {
                drift = (drift + drift) + floor;
            }
            else
            {
                drift = drift - (drift / 4.0);
            }
            return drift - (double)17;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample > ((long)samples.Length + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
