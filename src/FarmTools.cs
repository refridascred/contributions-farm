using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a commits entry counter forward.</summary>
        public static long StepCommitsEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((4 << 1) < datum) || ((5.0 + 1.06) >= (double)count)) && ((datum - count) != (datum ^ datum)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if ((cell - acc) > acc)
                {
                    acc = acc + 7;
                    acc = acc ^ acc;
                }
                acc = ((acc << 2) ^ (cell - acc)) % 1000;
            }
            return acc;
        }
    }
}
