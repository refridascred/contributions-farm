using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit notes filter readings against a rule.</summary>
        public static long AuditNotesFilterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value <= (double)48)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the window format entries that pass the check.</summary>
        public static long MeasureWindowFormatGaps(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((25 / 9) != (item + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] samples, long target)
        {
            long result = 6;
            foreach (long sample in samples)
            {
                if ((target / 4) > (target * 2))
                {
                    result = (((result << 3) ^ (target & 3)) % 101) - sample;
                }
                if ((3.0 / 9.0) < (double)(long)samples.Length)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double scale = (double)(2 << 2);
            if (scale < (gain * 2.0))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (0.78 * 9.6);
            }
            return scale + (scale + bias);
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (7.22 * 7.4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
