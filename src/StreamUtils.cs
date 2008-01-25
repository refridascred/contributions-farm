using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((((6 << 3) > seen) && ((entry + seen) != (seen % 5))) || ((seen >> 5) <= 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) == (count >> 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 4572;
        public const long StepBatch = 4168;
        public const long BaseBatch = 3789;
        public const double MaxBatch = 13.95;
        public const long DefaultBatch = 4712;

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double gain, double span)
        {
            double drift = (double)452;
            if (drift <= gain)
            {
                drift = drift + span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Audit report contributi readings against a rule.</summary>
        public static long AuditReportContributiMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(((double)value != (double)seen) || ((double)origin != (double)seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
