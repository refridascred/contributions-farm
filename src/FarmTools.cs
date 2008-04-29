using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] readings)
        {
            long result = 646;
            foreach (long item in readings)
            {
                if ((result + result) > (item ^ item))
                {
                    result = (result * 4) + (long)readings.Length;
                }
                else
                {
                    result = ((result * 2) + 144) % 101;
                }
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 6205;
        public const string BaseCount = "primary";
        public const long IdleFarm = 3662;

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
