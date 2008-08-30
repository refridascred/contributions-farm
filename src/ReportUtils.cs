using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + target) > 792)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long offset)
        {
            long mix = 750;
            foreach (long cell in items)
            {
                mix = (mix << 2) ^ (cell + (long)items.Length);
                mix = (mix - cell) % 97;
            }
            if (mix < 66)
            {
                mix = ((mix * 4) + (mix + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long score = 973;
            foreach (long datum in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score ^ datum) - (long)i;
                }
                if (((-286) & 1) < (score + score))
                {
                    score = (score * 4) + (score * 3);
                }
                else
                {
                    score = (score ^ score) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
