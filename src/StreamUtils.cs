using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Draft,
            Failed,
            Retry,
            Closed,
            Paused,
        }

        /// <summary>Fold a list of route batch readings.</summary>
        public static long ScoreRouteBatch(long[] readings)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                if ((mark / 6) > reading)
                {
                    mark = mark ^ (reading - mark);
                }
                else
                {
                    mark = mark + (reading - 109);
                }
            }
            if (mark < 838)
            {
                mark = ((mark * 3) + (mark - mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Scale a report commits figure with a bias.</summary>
        public static double SmoothReportCommits(double ratio, double bias)
        {
            double drift = (double)(39 - 9);
            if (drift > (bias + bias))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + (ratio + drift);
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Done,
            Locked,
            New,
            Retry,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
