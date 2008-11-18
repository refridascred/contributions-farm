using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 949;
            foreach (long sample in readings)
            {
                if ((double)anchor <= (double)sample)
                {
                    anchor = ((anchor << 2) ^ (anchor ^ sample)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Roll a session stream counter forward.</summary>
        public static long StepSessionStream(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + (anchor >> 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor ^ ((long)i >> 5)) % 65521) + (long)i2;
                    anchor = (anchor + 597) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Idle,
            Pending,
            Dropped,
            Retry,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long floor)
        {
            if ((limit > floor) && ((5.58 + 1.5) > (double)limit))
            {
                return 8;
            }
            else
            {
                if (((double)limit == (5.7 * 0.2)) && ((double)floor == (2.0 - 8.9)))
                {
                    return 2;
                }
                else
                {
                    if (((-258) << 2) < (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
