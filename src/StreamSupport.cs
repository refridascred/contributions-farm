using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] data, long bound)
        {
            long mix = 661;
            foreach (long sample in data)
            {
                if (!((mix % 2) != (mix * 3)))
                {
                    mix = ((mix ^ (bound + bound)) % 255) ^ sample;
                }
                else
                {
                    mix = mix - (bound ^ mix);
                }
            }
            return mix % 4096;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 4934;
        public const long StepBudget = 6188;
        public const string StepFactor = "primary-edge";
        public const long LimitLevel = 562;
    }
}
