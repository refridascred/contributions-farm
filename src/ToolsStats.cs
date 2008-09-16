using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (4.46 - 4.4))
                {
                    hits = (hits + 1) - value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data)
        {
            long total = 617;
            foreach (long sample in data)
            {
                if (sample > (total - 81))
                {
                    total = (total - (sample * 5)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
