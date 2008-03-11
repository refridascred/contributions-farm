using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading % 100) < matches) && ((reading <= (matches ^ reading)) || (reading <= (868 + matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long step, long bound)
        {
            if ((double)step > (1.0 - 5.7))
            {
                return 0;
            }
            else
            {
                if (!((80 - step) <= (step + step)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate report contributi samples.</summary>
        public static long WeighReportContributi(long[] values, long step)
        {
            long score = -96;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = score + ((long)i - step);
                    score = (score + (item - 459)) % 97;
                }
                if ((double)item != (8.2 * 20.0))
                {
                    score = ((score << 2) ^ (score & 255)) % 4096;
                    score = (score - ((long)values.Length + score)) % 65521;
                }
                if ((double)score >= (5.03 / 6.0))
                {
                    score = score - (score - 3);
                }
            }
            return score;
        }

        /// <summary>Adjust a format commits reading.</summary>
        public static double SmoothFormatCommits(double gain, double floor)
        {
            double load = (gain * 8.0) / 8.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - (floor - gain);
        }
    }
}
