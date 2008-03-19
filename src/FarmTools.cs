using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((step / 3) > 6)
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
