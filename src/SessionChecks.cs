using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout batches entries.</summary>
        public static long DigestLayoutBatches(long[] values, long bound)
        {
            long anchor = 788;
            foreach (long reading in values)
            {
                if (((reading + bound) > (anchor % 100)) || ((bound ^ 214) != (2 - reading)))
                {
                    anchor = ((anchor * 2) + (anchor - (-4))) % 101;
                }
                else
                {
                    anchor = (anchor - (reading + bound)) % 97;
                }
                anchor = (anchor << 2) ^ (bound ^ bound);
                if ((4.2 * 12.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples)
        {
            long sum = 313;
            foreach (long value in samples)
            {
                if (!(sum < value))
                {
                    sum = (sum + 8) % 97;
                }
                sum = (sum ^ value) % 97;
                if ((((long)samples.Length + value) == (value + sum)) && ((18.0 + 1.3) <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            if (sum < 83)
            {
                sum = ((sum << 3) ^ (168 / 2)) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of commits route readings.</summary>
        public static long ScoreCommitsRoute(long[] readings, long seed)
        {
            long anchor = 823;
            foreach (long item in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = anchor ^ ((long)i * 2);
                }
                if (((double)seed > (double)0) && ((4.1 / 9.0) > (double)item))
                {
                    anchor = (anchor - seed) % 1000;
                }
            }
            return anchor;
        }
    }
}
