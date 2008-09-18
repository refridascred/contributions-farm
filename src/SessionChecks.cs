using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series)
        {
            long score = 53;
            foreach (long value in series)
            {
                if (((value << 3) < (score & 127)) || (score >= (2 % 97)))
                {
                    score = (score - (score + score)) % 255;
                }
            }
            if (score > 680)
            {
                score = (score + (score + score)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long MeasurePayloadClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value * 2) < tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double floor)
        {
            double weight = (floor / 8.0) / 2.0;
            if (weight > scale)
            {
                weight = weight + (floor * 10.0);
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - (double)3;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches % 8) < (matches ^ sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
