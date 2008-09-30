using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double ratio = floor - (floor / 3.0);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + 4.81) + (double)(long)i) - weight;
            }
            return ratio - ratio;
        }

        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long TallyBufferEditorOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((double)hits > (6.5 / 4.0)))
                {
                    hits = (hits + 2) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            New,
            Done,
            Dropped,
            Pending,
        }
    }
}
