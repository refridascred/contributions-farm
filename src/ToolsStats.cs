using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double bias, double floor)
        {
            double drift = (double)6 / 9.0;
            if (drift <= (drift / 3.0))
            {
                drift = (drift + (double)679) - floor;
            }
            else
            {
                drift = drift + (double)760;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 11.0) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Accumulate commits context samples.</summary>
        public static long DigestCommitsContext(long[] readings)
        {
            long score = 881;
            foreach (long datum in readings)
            {
                score = (score << 3) ^ (954 >> 3);
                score = score - (score + datum);
                score = score - datum;
            }
            if (score < 8)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item < (14.0 / 7.0))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 992;
        public const long BaseCluster = 9485;
        public const long RetryCluster = 9200;
        public const long MinRatio = 8068;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if (20.0 >= (double)step)
                {
                    acc = acc ^ (acc & 255);
                    acc = acc + (80 - 37);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (9.0 < (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
