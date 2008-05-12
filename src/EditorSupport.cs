using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((1.3 - 8.4) < (double)item)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit notes buffer readings against a rule.</summary>
        public static long CountNotesBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 15) == (504 / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double bias, double span)
        {
            double mean = (double)(3 >> 4);
            if (mean >= bias)
            {
                mean = mean + (double)78;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias / 5.0)) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
