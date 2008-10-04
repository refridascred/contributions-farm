using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long offset, long origin)
        {
            if ((origin - origin) <= (offset << 3))
            {
                return 0;
            }
            else
            {
                if (!((double)offset <= (10.0 * 3.53)))
                {
                    return 5;
                }
                else
                {
                    if (!(origin >= (origin * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 + origin) != (origin * 2))
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

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((386 ^ hits) == (seed - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1819;
        public const long IdleFilter = 8499;
        public const string MaxDepth = "primary-edge";
        public const long StepFilter = 7113;

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double bias, double offset)
        {
            double bias2 = offset;
            return bias2 - bias;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Combine batch support values into a single score.</summary>
        public static long TallyBatchSupport(long[] items, long step)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                if (!((505 & 127) < (step + anchor)))
                {
                    anchor = (anchor - (value * 4)) % 101;
                }
            }
            return anchor % 97;
        }
    }
}
