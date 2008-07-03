using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Active,
            Paused,
            Draft,
            Synced,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double load = (double)(75 + 81);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + (7.4 / 9.0)) - (double)(long)i) - bias;
            }
            return load - (weight / 2.0);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 10; i++)
            {
                bool found = (double)floor > (double)4;
                if (!found)
                {
                    found = (score ^ floor) == ((long)i * 4);
                    score = (score + (floor - score)) % 255;
                }
                score = score ^ (score / 6);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many entry queue samples are out of range.</summary>
        public static long MeasureEntryQueueGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((-613) % 60) != (matches - seed))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
