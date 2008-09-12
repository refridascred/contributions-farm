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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 4934;
        public const long StepBudget = 6188;
        public const string StepFactor = "primary-edge";
        public const long LimitLevel = 562;
    }
}
