using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((6 + entry) >= 787)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= floor)
            {
                mean = mean - 7.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - (ratio - floor);
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Failed,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Roll a commits account counter forward.</summary>
        public static long IterateCommitsAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score + (71 & 63)) % 255) - (long)i2;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
