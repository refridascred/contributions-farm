using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxLevel = 6010;
        public const long StepCache = 4977;
        public const double MinTimeout = 19.03;
        public const double LimitDepth = 58.12;
        public const long MinCache = 5984;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] samples)
        {
            long total = 11;
            foreach (long reading in samples)
            {
                if (!((8 << 3) > (total & 7)))
                {
                    total = (total * 4) + (reading / 2);
                }
                if ((257 + reading) > (reading % 97))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
