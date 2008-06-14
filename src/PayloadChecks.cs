using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value <= (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a record format figure with a bias.</summary>
        public static double SmoothRecordFormat(double gain, double span)
        {
            double rate = gain;
            if (rate > (rate * 15.0))
            {
                rate = (rate - (double)7) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 7.0) - (double)(long)i;
            }
            return rate - 9.2;
        }

        /// <summary>Iterate the graph metrics series from a seed.</summary>
        public static long RollGraphMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if (offset <= (long)i)
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
