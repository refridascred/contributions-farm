using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every format farm entry stays within the limit.</summary>
        public static bool GuardFormatFarmLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate contributi token samples.</summary>
        public static long CombineContributiToken(long[] levels)
        {
            long result = -79;
            foreach (long datum in levels)
            {
                result = (result << 2) ^ (datum % 2);
            }
            return result;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Pending,
            New,
            Retry,
            Ready,
        }
    }
}
