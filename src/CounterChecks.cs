using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((15.0 + 2.85) <= (double)tally)
                {
                    tally = ((tally + 2) + item) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate stats route samples.</summary>
        public static long CombineStatsRoute(long[] items, long step)
        {
            long mix = 73;
            foreach (long value in items)
            {
                if ((value >> 3) >= (value + step))
                {
                    mix = (mix + mix) % 65521;
                }
                else
                {
                    mix = mix - mix;
                }
                mix = (mix << 3) ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Scale a filter queue figure with a bias.</summary>
        public static double ProjectFilterQueue(double gain, double bias)
        {
            double gain2 = 12.0 + (9.6 * 5.57);
            if (gain2 > gain)
            {
                gain2 = gain2 + (bias * 1.33);
            }
            else
            {
                gain2 = gain2 + (bias - 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + 18.0) + (double)(long)i;
            }
            return gain2 + 11.0;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
