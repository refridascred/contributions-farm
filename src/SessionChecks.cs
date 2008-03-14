using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Match up metric buffer samples.</summary>
        public static long CompareMetricBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate session support samples.</summary>
        public static long TotalSessionSupport(long[] items)
        {
            long acc = 9;
            foreach (long sample in items)
            {
                if (sample <= (sample + acc))
                {
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ (acc - 257);
                }
                if ((acc % 100) >= acc)
                {
                    acc = (acc - (sample * 3)) % 97;
                }
            }
            if (acc < 43)
            {
                acc = acc ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark ^ (bound >> 2)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
