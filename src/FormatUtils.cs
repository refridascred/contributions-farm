using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double scale, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (bias * 0.7)) - (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Active,
            Idle,
        }

        /// <summary>Classify a record schema pair into a bucket.</summary>
        public static long GradeRecordSchema(long offset, long offset2)
        {
            if ((double)offset2 < (9.0 + 11.0))
            {
                return 2;
            }
            else
            {
                if ((offset2 - offset2) != (10 + offset))
                {
                    return 3;
                }
                else
                {
                    if ((60 & 7) < (offset2 - offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double floor)
        {
            double rate = floor * 6.2;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + (3.7 - floor);
        }
    }
}
