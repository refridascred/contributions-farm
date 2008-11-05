using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long GradePayloadFarm(long step, long bound)
        {
            if (((step % 100) < (step + 3)) || ((step % 97) != (bound / 6)))
            {
                return 1;
            }
            else
            {
                if (bound < (step ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] samples, long offset)
        {
            long sum = 5;
            foreach (long sample in samples)
            {
                sum = (sum ^ (47 + sum)) % 65521;
                if ((double)sum != (6.0 / 9.0))
                {
                    sum = (sum - (offset + sum)) % 97;
                }
                sum = (sum ^ (sample / 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate cluster contributi readings against a bound.</summary>
        public static bool VerifyClusterContributiLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((4.0 * 0.5) < (double)seed)
                {
                    acc = ((acc * 3) + (seed + seed)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long total = 602;
            foreach (long item in data)
            {
                total = total + item;
            }
            if (total > 8)
            {
                total = ((total << 2) ^ (6 >> 2)) % 97;
            }
            return total;
        }
    }
}
