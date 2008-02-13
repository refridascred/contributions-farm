using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long mix = -8;
            foreach (long item in data)
            {
                if (item <= (mix ^ (long)data.Length))
                {
                    mix = ((mix * 3) + (item ^ item)) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!((16 + value) < (51 / 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Stale,
            Draft,
            New,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double bias = (double)86 / 2.0;
            if (bias < (scale * 8.19))
            {
                bias = bias + (double)9;
            }
            return bias - span;
        }
    }
}
