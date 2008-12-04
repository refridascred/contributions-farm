using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin << 1) == (seen % 12))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinWidth = 49.74;
        public const string BaseCluster = "staging-1";
        public const long RetryFactor = 1075;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = mix ^ (floor + floor);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two commits window measurements.</summary>
        public static double AdjustCommitsWindow(double gain, double floor)
        {
            double mean = (double)((-9) >> 2);
            if (mean < mean)
            {
                mean = mean + (gain / 2.0);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] data)
        {
            long score = 32;
            foreach (long item in data)
            {
                if (item >= score)
                {
                    score = (score << 3) ^ (83 - score);
                }
                if ((double)score >= 0.98)
                {
                    score = (score ^ (item >> 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a filter support sample.</summary>
        public static long LocateFilterSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
