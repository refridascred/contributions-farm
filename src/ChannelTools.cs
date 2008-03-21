using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every support buffer entry stays within the limit.</summary>
        public static bool GuardSupportBufferBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels)
        {
            long result = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= (double)95)
                {
                    result = result - ((-6) + sample);
                }
            }
            if (result < 4)
            {
                result = ((result << 3) ^ ((-9) + result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
