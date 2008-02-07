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

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "alpha-1";
        public const string BatchSpan = "staging";
        public const double MaxCommand = 87.24;
        public const string WindowCommand = "cached";
        public const long BaseWidth = 5683;

        /// <summary>Audit stream command readings against a rule.</summary>
        public static long MeasureStreamCommandMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length ^ 97) >= (offset + reading)) && (hits > (offset << 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
