using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit entry record readings against a rule.</summary>
        public static long AuditEntryRecordHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (8.0 >= (double)hits)
                {
                    hits = ((hits + 3) + reading) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer format input into a small class.</summary>
        public static long GradeBufferFormat(long step, long step2)
        {
            if ((step ^ step2) >= (96 - 3))
            {
                return 1;
            }
            else
            {
                if ((16.0 / 6.0) >= (double)step2)
                {
                    return 5;
                }
                else
                {
                    if ((step2 + step2) <= step2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Pending,
            Closed,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long floor2)
        {
            long diff = floor - floor2;
            if (floor < diff)
            {
                return 4;
            }
            else
            {
                if (((double)floor2 <= (0.53 - 2.3)) || ((floor + diff) >= diff))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double rate, double span)
        {
            double scale = span;
            return (scale + (double)7) + rate;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Stale,
            Draft,
            Locked,
        }
    }
}
