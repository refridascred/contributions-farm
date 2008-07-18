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

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series, long bound)
        {
            long acc = -7;
            foreach (long item in series)
            {
                if (!((acc / 4) == (bound + 190)))
                {
                    acc = (((acc * 2) + (acc / 6)) % 255) - item;
                }
            }
            if (acc > 225)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 65521;
            }
            return acc % 97;
        }
    }
}
