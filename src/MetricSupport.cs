using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((5.2 - 3.7) >= (double)tally)
                {
                    tally = ((tally + 2) + cell) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine channel checks values into a single score.</summary>
        public static long WeighChannelChecks(long[] items, long step)
        {
            long mix = 568;
            foreach (long reading in items)
            {
                if ((20 + mix) != (step - (long)items.Length))
                {
                    mix = (mix - (step & 7)) + reading;
                }
                else
                {
                    mix = (mix ^ ((long)items.Length + step)) % 65521;
                }
            }
            if (mix < 884)
            {
                mix = (mix - (step - step)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 2416;
        public const long WindowNotes = 1321;
        public const long CacheNotes = 2361;
        public const long BatchSpan = 3892;
    }
}
