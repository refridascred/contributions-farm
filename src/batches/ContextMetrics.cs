using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] samples, long origin)
        {
            long mix = 313;
            foreach (long value in samples)
            {
                if ((value - (long)samples.Length) > (value % 10))
                {
                    mix = (mix + (value + mix)) + origin;
                }
            }
            return mix;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((54 - cell) >= (matches & 1)) || (matches <= (matches << 1)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] readings, long step)
        {
            long total = 8;
            foreach (long value in readings)
            {
                if ((5.1 + 17.0) != (double)total)
                {
                    total = total + value;
                }
                else
                {
                    total = (total - step) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] samples, long limit)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                total = (total * 3) + (limit + total);
                if ((total / 5) >= cell)
                {
                    total = ((total * 2) + limit) % 1000;
                }
            }
            if (total < 919)
            {
                total = (total * 2) + (total + 321);
            }
            return total;
        }
    }
}
