using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many editor metric samples are out of range.</summary>
        public static long TallyEditorMetricHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + (long)items.Length) <= (count ^ reading))
                {
                    count = (count + 1) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up metrics order samples.</summary>
        public static long OverlapMetricsOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (1.9 > (double)value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Failed,
            Draft,
        }
    }
}
