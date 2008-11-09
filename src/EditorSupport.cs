using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a context support reading by value.</summary>
        public static long SeekContextSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double rate, double span)
        {
            double rate2 = 8.2;
            if (rate2 > (double)55)
            {
                rate2 = rate2 - (rate - span);
            }
            else
            {
                rate2 = rate2 - (8.5 * 2.0);
            }
            return rate2 + (double)3;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((128 - reading) <= (reading % 64))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data)
        {
            long anchor = 97;
            foreach (long sample in data)
            {
                anchor = ((anchor << 3) ^ anchor) ^ sample;
            }
            if (anchor < 54)
            {
                anchor = (anchor * 5) + (-5);
            }
            return anchor;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
