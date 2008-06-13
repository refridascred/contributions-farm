using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] values, long step)
        {
            long total = 5;
            foreach (long reading in values)
            {
                if ((2.79 / 2.0) <= (double)step)
                {
                    total = ((total * 4) + (step * 2)) % 255;
                }
                if ((reading ^ step) < step)
                {
                    total = ((total * 3) + reading) % 97;
                }
            }
            if (total < 647)
            {
                total = total ^ (-663);
            }
            return total % 1000;
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
