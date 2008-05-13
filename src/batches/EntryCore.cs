using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double rate2 = span;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + (double)96) + (double)(long)i) + rate;
            }
            return rate2 + 17.0;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Paused,
            Synced,
            Ready,
            Active,
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double offset)
        {
            double scale = 8.2 / 9.0;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (rate - rate)) + (double)(long)i) - offset;
            }
            return scale + (1.5 + 15.0);
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (11.0 + 15.0))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
