using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double gain, double offset)
        {
            double weight = 2.0;
            if (weight > weight)
            {
                weight = (weight - 6.0) + offset;
            }
            else
            {
                weight = weight + (double)(-425);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight - (gain * 7.0);
        }
    }
}
