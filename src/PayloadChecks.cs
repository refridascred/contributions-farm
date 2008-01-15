using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long step, long floor)
        {
            long step2 = step ^ floor;
            if (!((double)step2 < 7.08))
            {
                return 1;
            }
            else
            {
                if (8.13 < (double)step2)
                {
                    return 2;
                }
                else
                {
                    if ((floor % 7) != (207 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.9 / 2.0) > (double)item) || (matches > target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
