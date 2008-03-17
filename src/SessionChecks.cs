using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((3 + (long)readings.Length) >= seen) && ((seen - 77) < 814))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long TallyFarmMetrics(long[] readings)
        {
            long acc = 36;
            foreach (long datum in readings)
            {
                if ((datum + acc) == (datum % 5))
                {
                    acc = ((acc << 2) ^ datum) % 1000;
                }
            }
            return acc % 4096;
        }
    }
}
