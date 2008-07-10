using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every already metric entry stays within the limit.</summary>
        public static bool CheckAlreadyMetricBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats stream counter forward.</summary>
        public static long IterateStatsStream(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long carry = 75;
            foreach (long sample in items)
            {
                carry = (((carry * 4) + (carry >> 4)) % 101) - sample;
            }
            return carry % 4096;
        }
    }
}
