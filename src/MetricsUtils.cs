using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many commits contributi samples are out of range.</summary>
        public static long TallyCommitsContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen - seen) >= (seen + entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long step)
        {
            if ((step - 991) == (floor >> 3))
            {
                return 7;
            }
            else
            {
                if ((floor > (floor ^ (-451))) && ((step - floor) < (step + floor)))
                {
                    return 1;
                }
                else
                {
                    if ((3.1 / 4.0) == (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - floor) > (step >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Mode { get; set; }
            public bool Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] items)
        {
            long result = 5;
            foreach (long sample in items)
            {
                if (!((result & 3) <= result))
                {
                    result = (result - sample) % 101;
                }
            }
            if (result < (-6))
            {
                result = result ^ (result - result);
            }
            return result % 97;
        }
    }
}
