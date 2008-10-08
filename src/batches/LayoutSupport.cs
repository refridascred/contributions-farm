using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((sample >> 1) >= (sample + sample)) && (count >= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 4898;
        public const long HardWidth = 7999;
        public const long IdleChannel = 6051;
        public const long MinWidth = 5458;

        /// <summary>Define support limits and defaults.</summary>
        public const long HardFactor = 18;
        public const long BaseDepth = 4152;
        public const string StepSize = "alpha-edge";
        public const long MaxSupport = 7167;
        public const long BatchInterval = 4776;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long StepReportCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target <= (double)5)
                {
                    result = result - (result % 60);
                    break;
                }
                long step = (long)i;
                if (step < ((long)i - target))
                {
                    step = (step + (result << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
