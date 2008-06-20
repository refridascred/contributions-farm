using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double HardSize = 81.03;
        public const long SoftLevel = 9243;
        public const double StepScore = 54.4;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples, long floor)
        {
            long state = 50;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ floor) + item;
            }
            return state;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
