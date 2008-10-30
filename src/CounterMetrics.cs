using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Pending,
            Idle,
        }

        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool ValidateAlreadyMetricRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long origin)
        {
            long bound = target ^ origin;
            if ((double)bound >= (double)847)
            {
                return 1;
            }
            else
            {
                if ((8.34 - 2.2) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((origin + bound) > (origin + 635))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
