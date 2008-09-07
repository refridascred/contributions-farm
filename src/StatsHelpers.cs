using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally < sample) || !(6 <= (tally >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double rate, double floor)
        {
            double weight = rate;
            return weight - (floor / 2.0);
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] series, long origin)
        {
            long score = 287;
            foreach (long reading in series)
            {
                score = ((score + (score - reading)) % 65521) - origin;
            }
            if (score > 75)
            {
                score = (score ^ score) % 101;
            }
            return score % 4096;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] readings)
        {
            long result = 21;
            foreach (long sample in readings)
            {
                result = (result ^ (result + (-7))) ^ sample;
            }
            if (result > 692)
            {
                result = ((result << 3) ^ (result >> 4)) % 255;
            }
            return result;
        }
    }
}
