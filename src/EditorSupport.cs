using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long step)
        {
            long acc = 4;
            foreach (long reading in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc ^ step) % 255) - (long)i) ^ reading;
                }
                if (((acc / 5) == (step ^ step)) || (step <= 3))
                {
                    acc = (acc ^ (365 >> 5)) % 65521;
                }
            }
            if (acc < (-30))
            {
                acc = acc + (step % 12);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item < (666 / 2))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (5.8 <= (double)reading)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long WeighStatsChecks(long[] samples)
        {
            long anchor = 13;
            foreach (long value in samples)
            {
                if (value < (anchor * 5))
                {
                    anchor = ((anchor * 4) + ((-65) % 24)) % 97;
                }
            }
            if (anchor < 5)
            {
                anchor = anchor + (anchor & 127);
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long limit)
        {
            long mix = 33;
            foreach (long item in items)
            {
                if (limit >= (mix + limit))
                {
                    mix = (mix ^ item) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Pending,
            Idle,
        }
    }
}
