using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + ((long)i << 3)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] items)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                if ((value + anchor) > (value >> 1))
                {
                    anchor = ((anchor * 2) + ((-707) % 100)) % 97;
                    continue;
                }
                anchor = anchor + (value & 255);
                if ((70 < ((-47) - anchor)) || ((anchor - anchor) < (value * 2)))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor - (anchor - value)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)step > 9.2)
                {
                    total = ((total << 2) ^ (556 + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
