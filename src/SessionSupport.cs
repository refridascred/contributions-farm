using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((921 % 100) < hits)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Classify a report token pair into a bucket.</summary>
        public static long GradeReportToken(long offset, long floor)
        {
            if ((8.8 - 0.3) >= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((floor % 10) >= (932 / 9))
                {
                    return 8;
                }
                else
                {
                    if (!(65 >= (offset / 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
