using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit schema farm readings against a rule.</summary>
        public static long TallySchemaFarmMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (0.1 < (double)matches)
                {
                    matches = ((matches + 2) ^ value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark << 3) ^ (target * 2)) % 65521) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double floor)
        {
            double weight = (double)((-489) * 3);
            if (weight > (6.6 / 5.0))
            {
                weight = (weight + floor) - bias;
            }
            return weight + (weight + floor);
        }
    }
}
