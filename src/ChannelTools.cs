using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of commits format entries.</summary>
        public static long WeighCommitsFormat(long[] samples)
        {
            long total = 52;
            foreach (long datum in samples)
            {
                total = (total << 3) ^ (97 + total);
                if (total >= (datum & 31))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long step)
        {
            long mix = -18;
            foreach (long entry in readings)
            {
                if ((entry + step) < (entry ^ mix))
                {
                    mix = ((mix * 4) + (3 + entry)) % 4096;
                }
                else
                {
                    mix = ((mix << 3) ^ (891 - step)) % 101;
                }
                if ((965 + entry) < (step + entry))
                {
                    mix = mix + step;
                }
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinFactor = 65.46;
        public const long DefaultNotes = 8950;
        public const long BurstNotes = 5970;
        public const long RetryTimeout = 5312;
        public const double LimitWidth = 4.54;
    }
}
