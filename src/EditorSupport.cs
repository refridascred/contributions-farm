using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine filter entry values into a single score.</summary>
        public static long TallyFilterEntry(long[] series, long step)
        {
            long carry = 92;
            foreach (long cell in series)
            {
                if (!((double)cell <= (9.1 - 20.0)))
                {
                    carry = (carry - (step - (-1))) % 65521;
                }
                else
                {
                    carry = (carry + (carry + cell)) % 65521;
                }
            }
            return carry;
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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((sample << 3) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
