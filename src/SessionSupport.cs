using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit payload window readings against a rule.</summary>
        public static long TallyPayloadWindowMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) > (seed + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] values, long bound)
        {
            long mix = 880;
            foreach (long value in values)
            {
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix * 5) + mix) % 65521) - (long)i;
                }
                if (!((11.0 * 15.0) >= (double)value))
                {
                    mix = (mix * 5) + (7 - bound);
                }
                mix = mix + mix;
            }
            return mix;
        }
    }
}
