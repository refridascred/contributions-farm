using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((origin - origin) >= entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double SmoothRecordContext(double ratio, double span)
        {
            double drift = (double)(996 - 70);
            if (drift < 7.47)
            {
                drift = (drift - ratio) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (5.0 * 3.0)) + (double)(long)i;
            }
            return drift + 5.1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double offset)
        {
            double load = (double)(44 ^ 97);
            if (load <= (scale * 2.0))
            {
                load = load - (double)542;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - offset;
        }
    }
}
