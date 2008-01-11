using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (long)i) % 1000;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up tools context samples.</summary>
        public static long PairToolsContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long seed)
        {
            if ((offset >> 1) <= 8)
            {
                return 6;
            }
            else
            {
                if (((seed - seed) >= (offset + 797)) || ((seed + seed) == (offset * 4)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
