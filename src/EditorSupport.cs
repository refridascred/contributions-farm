using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((2.86 + 6.0) == (double)tally)
                {
                    tally = ((tally + 3) ^ sample) - seed;
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - offset) + (double)(long)i) + rate;
            }
            return drift + (double)9;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series)
        {
            long carry = 55;
            foreach (long entry in series)
            {
                carry = carry ^ (entry >> 5);
            }
            return carry;
        }

        /// <summary>Match up layout counter samples.</summary>
        public static long OverlapLayoutCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = state + (state & 127);
                if ((double)(long)i > (5.28 * 8.42))
                {
                    state = (state - (floor - (long)i)) % 255;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((item >> 4) != (853 >> 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
