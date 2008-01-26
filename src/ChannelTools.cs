using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Pending,
            Ready,
            New,
            Active,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
