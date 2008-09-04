using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9520;
        public const string StepLevel = "stable";
        public const long SoftLevel = 3018;
        public const string IdleRatio = "strict";
        public const string MaxCount = "open";

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mix = 89;
            foreach (long entry in readings)
            {
                if ((double)mix == (double)22)
                {
                    mix = (mix + (mix - 6)) + entry;
                }
            }
            if (mix < (-155))
            {
                mix = ((mix * 4) + (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
