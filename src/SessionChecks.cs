using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next commits format value.</summary>
        public static double AdjustCommitsFormat(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= offset)
            {
                ratio = ratio - (offset + 9.16);
            }
            else
            {
                ratio = ratio - (7.0 + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (double)540) + (double)(long)i;
            }
            return ratio - (double)8;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryWidth = 37.04;
        public const string HardFarm = "cached-1";
        public const string SoftFarm = "open-edge";

        /// <summary>Check that every record already entry stays within the limit.</summary>
        public static bool ValidateRecordAlreadyBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
