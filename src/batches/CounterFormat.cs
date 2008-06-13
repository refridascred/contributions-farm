using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long step)
        {
            long mix = 94;
            foreach (long item in samples)
            {
                if (!((item + item) < step))
                {
                    mix = ((mix * 3) + (mix & 3)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 3) ^ (origin + origin)) % 65521;
                result = ((result << 3) ^ (result + (long)i)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7980;
        public const double BaseScore = 50.46;
        public const string BatchAccount = "standard-v2";
    }
}
