using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double floor)
        {
            double weight = (double)(699 * 3);
            if (weight <= (floor / 7.0))
            {
                weight = weight - 0.6;
            }
            else
            {
                weight = weight - (ratio / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + weight)) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] data, long origin)
        {
            long acc = 250;
            foreach (long entry in data)
            {
                if ((49 + origin) > (origin & 3))
                {
                    acc = acc ^ (entry + 443);
                }
            }
            return acc;
        }

        /// <summary>Adjust a notes contributi reading.</summary>
        public static double ScaleNotesContributi(double ratio, double bias)
        {
            double weight = bias;
            if (weight <= bias)
            {
                weight = (weight + (bias / 3.0)) - ratio;
            }
            else
            {
                weight = weight - bias;
            }
            return weight + (double)787;
        }

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long MeasureCommitsBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item + item) > (94 & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
