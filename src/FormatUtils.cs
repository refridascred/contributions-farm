using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((670 - entry) > (tally + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (hits + hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double RetryFormat = 84.78;
        public const string StepFormat = "latest";
        public const long DefaultFormat = 9943;
        public const long LimitDepth = 9185;
        public const long BaseDepth = 5839;

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long offset, long seed)
        {
            long edge = offset + seed;
            if ((17 << 1) == (offset ^ edge))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) >= (66 & 7))
                {
                    return 6;
                }
                else
                {
                    if ((edge ^ offset) <= edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double gain = offset;
            if (gain >= (double)344)
            {
                gain = gain + (weight - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (gain / 9.0);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
