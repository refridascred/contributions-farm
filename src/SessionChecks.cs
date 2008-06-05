using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((9.53 + 13.0) <= (double)item) || (((floor & 63) != (93 + seen)) || (seen >= (seen - seen))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc ^ acc) % 65521) + (long)i2;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit stats queue readings against a rule.</summary>
        public static long CountStatsQueueHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading > (count + 193))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + step) % 1000;
                if ((step / 2) >= step)
                {
                    acc = acc + (acc + 398);
                }
                else
                {
                    long matches = (long)i;
                    acc = acc ^ ((long)i + matches);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
