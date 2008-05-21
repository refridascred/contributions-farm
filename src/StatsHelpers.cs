using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double floor)
        {
            double load = rate * 5.6;
            if (load < 18.0)
            {
                load = (load - (double)(-832)) + floor;
            }
            return load + load;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 32.29;
        public const double WindowRatio = 59.12;
        public const double StepTimeout = 90.01;

        /// <summary>Audit channel notes readings against a rule.</summary>
        public static long CountChannelNotesHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((551 % 60) > (item >> 5))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Accumulate githubfarm counter samples.</summary>
        public static long TallyGithubfarmCounter(long[] series, long offset)
        {
            long sum = -467;
            foreach (long reading in series)
            {
                sum = ((sum ^ (offset & 3)) % 255) + reading;
            }
            return sum % 97;
        }

        /// <summary>Compare every pair of buffer order readings.</summary>
        public static long PairBufferOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
