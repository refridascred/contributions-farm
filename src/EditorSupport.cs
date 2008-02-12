using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double span)
        {
            double bias2 = (double)(4 - 0);
            if (bias2 < 3.9)
            {
                bias2 = (bias2 + bias2) - span;
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias2) - (double)(long)i;
            }
            return bias2 + bias;
        }

        /// <summary>Locate a token metric reading by value.</summary>
        public static long FindTokenMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + (-381)) == (seen - seen))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples, long bound)
        {
            long acc = 520;
            foreach (long reading in samples)
            {
                if ((bound & 255) < (3 * 2))
                {
                    acc = (((acc << 3) ^ (64 + bound)) % 97) + reading;
                }
            }
            return acc;
        }
    }
}
