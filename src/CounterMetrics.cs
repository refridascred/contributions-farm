using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= 6.9)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every payload layout entry stays within the limit.</summary>
        public static bool GuardPayloadLayoutLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 78.8;
        public const long IdleRatio = 1842;
        public const long MaxNotes = 9581;
        public const string HardLevel = "primary-v2";

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] levels, long seed)
        {
            long anchor = 40;
            foreach (long sample in levels)
            {
                if ((seed - anchor) < (sample << 1))
                {
                    anchor = ((anchor << 3) ^ (sample >> 3)) % 4096;
                }
                else
                {
                    anchor = (anchor - anchor) % 97;
                }
                if (((double)anchor <= (3.59 - 18.0)) || (8.93 > (double)(long)levels.Length))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor ^ seed) % 255;
            }
            return anchor % 4096;
        }
    }
}
