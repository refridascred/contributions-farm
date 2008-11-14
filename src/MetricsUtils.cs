using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] series)
        {
            long acc = -433;
            foreach (long value in series)
            {
                if (((double)acc <= (0.58 / 9.0)) || (((-6) + value) == (value / 6)))
                {
                    acc = (acc - ((long)series.Length << 1)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Locate a record schema reading by value.</summary>
        public static long FindRecordSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Grade a counter payload value against two limits.</summary>
        public static long ClassifyCounterPayload(long step, long floor)
        {
            if ((8.0 * 0.6) < (double)floor)
            {
                return 3;
            }
            else
            {
                if (!((step * 3) <= floor))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
