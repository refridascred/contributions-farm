using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)65 >= (double)value) && ((value % 97) == (offset * 5)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double mean = bias * 7.4;
            if (mean >= (scale - mean))
            {
                mean = mean + scale;
            }
            return mean + mean;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long seed, long offset)
        {
            if ((seed % 8) == (seed / 2))
            {
                return 0;
            }
            else
            {
                if ((offset - offset) < (seed << 2))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (offset + 39))
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed < (offset << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
