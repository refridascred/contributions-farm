using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (12.0 - rate) / 5.0;
            if (rate2 <= bias)
            {
                rate2 = rate2 - (double)364;
            }
            return rate2 + 1.65;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double load = (double)((-151) + 42);
            if (load > (double)326)
            {
                load = ((load + (double)0) - rate) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (5.2 * 3.0);
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen != (0.54 + 4.2))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window profile samples are out of range.</summary>
        public static long TallyWindowProfileHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum <= (step * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] readings)
        {
            long state = -941;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ sample) % 1000;
                state = (state ^ (sample >> 3)) % 255;
                state = (state ^ (sample & 31)) % 1000;
            }
            if (state < 2)
            {
                state = (state << 2) ^ (state ^ state);
            }
            return state;
        }
    }
}
