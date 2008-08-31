using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long seed)
        {
            if (791 <= (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((seed ^ seed) > 34)
                {
                    return 6;
                }
                else
                {
                    if (!((seed * 3) > (67 ^ seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed <= (6.8 + 2.58))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long TallyStatsRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item >= (item ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric account reading by value.</summary>
        public static long LookupMetricAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Synced,
            New,
            Ready,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double load = (bias / 9.0) / 2.0;
            if (load >= 9.6)
            {
                load = (load + bias) + bias2;
            }
            return load - (bias * 13.0);
        }
    }
}
