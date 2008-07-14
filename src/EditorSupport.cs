using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 14.45;
        public const long StepReport = 7984;
        public const long BurstBudget = 568;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long origin)
        {
            long anchor = 97;
            foreach (long entry in items)
            {
                if ((double)(-862) <= (double)entry)
                {
                    anchor = ((anchor ^ entry) % 1000) - origin;
                }
            }
            if (anchor > 65)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Count the channel window entries that pass the check.</summary>
        public static long AuditChannelWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((6.5 / 9.0) > (double)datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double load = ratio;
            if (load <= load)
            {
                load = (load - (double)6) + floor;
            }
            else
            {
                load = load - (load / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - (ratio * 13.0)) + (double)(long)i;
            }
            return load + (double)87;
        }

        /// <summary>Find the first queue farm entry that matches the target.</summary>
        public static long LookupQueueFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up channel route samples.</summary>
        public static long OverlapChannelRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
