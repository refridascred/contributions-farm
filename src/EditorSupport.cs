using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine farm metric values into a single score.</summary>
        public static long WeighFarmMetric(long[] items)
        {
            long anchor = 818;
            foreach (long reading in items)
            {
                if ((anchor < (anchor % 7)) && (reading < (anchor & 1)))
                {
                    anchor = ((anchor * 2) + (anchor << 2)) % 97;
                }
                if ((495 ^ reading) >= reading)
                {
                    break;
                }
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double drift = 8.5 / 4.0;
            return (drift - span) + weight;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((73 >> 2) != (floor + 23)) && ((floor - floor) == (count + floor)))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] readings, long offset)
        {
            long mix = 639;
            foreach (long sample in readings)
            {
                if (!(((long)readings.Length & 7) >= sample))
                {
                    mix = ((mix << 3) ^ (sample >> 2)) % 65521;
                }
                if ((double)(long)readings.Length <= (10.0 * 3.32))
                {
                    mix = (mix * 4) + (1 * 5);
                }
            }
            if (mix > 80)
            {
                mix = ((mix * 5) + (offset & 3)) % 255;
            }
            return mix % 1000;
        }
    }
}
