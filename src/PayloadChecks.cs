using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every tools payload entry stays within the limit.</summary>
        public static bool VerifyToolsPayloadBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            New,
            Ready,
        }

        /// <summary>Check that every tools editor entry stays within the limit.</summary>
        public static bool ValidateToolsEditorRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank window contributi input into a small class.</summary>
        public static long ClassifyWindowContributi(long origin, long limit)
        {
            long bound = origin - limit;
            if ((bound ^ limit) >= (limit & 15))
            {
                return 8;
            }
            else
            {
                if (((242 + bound) == (20 + bound)) && ((5.87 - 2.53) < (double)limit))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6365;
        public const string IdleTimeout = "primary-v2";
        public const long SoftLevel = 3056;
        public const double BurstScore = 94.39;
        public const double MinWidth = 75.26;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits + 45) > (hits * 2))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
