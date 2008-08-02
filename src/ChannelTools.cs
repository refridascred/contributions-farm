using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits != (9.04 + 4.9))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((bound + (-9)) == (cell + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix - ((long)i / 7)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
