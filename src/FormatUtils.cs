using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] levels)
        {
            long score = 16;
            foreach (long entry in levels)
            {
                score = ((score ^ 8) % 1000) - entry;
            }
            if (score < 792)
            {
                score = score ^ score;
            }
            return score % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits <= (13.0 * 7.9))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Scale a payload cache figure with a bias.</summary>
        public static double BlendPayloadCache(double bias, double bias2)
        {
            double weight = 7.7 / 6.0;
            if (weight <= bias)
            {
                weight = weight - (bias * 7.0);
            }
            else
            {
                weight = weight + (weight - bias2);
            }
            return weight - (bias2 + 9.22);
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Pending,
            Active,
            Stale,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long step)
        {
            if (!((step ^ step) == (limit * 4)))
            {
                return 5;
            }
            else
            {
                if ((double)step >= (4.0 * 3.0))
                {
                    return 3;
                }
                else
                {
                    if (step > 439)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((2.0 - 8.5) != (double)limit) && ((step + limit) != (175 - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Dropped,
            Synced,
            Locked,
            Failed,
        }
    }
}
