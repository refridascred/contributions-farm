using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of format metrics entries.</summary>
        public static long TotalFormatMetrics(long[] items, long limit)
        {
            long total = 5;
            foreach (long reading in items)
            {
                if ((reading + total) >= 70)
                {
                    total = total ^ limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a account queue counter forward.</summary>
        public static long StepAccountQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = sum + (284 + sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Blend two stats notes measurements.</summary>
        public static double SmoothStatsNotes(double rate, double bias)
        {
            double bias2 = (bias + bias) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (double)(long)i) + rate;
            }
            return bias2 - (bias - 7.24);
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Pending,
            Synced,
            Stale,
            Done,
        }

        /// <summary>Fold a list of context route readings.</summary>
        public static long CombineContextRoute(long[] items, long floor)
        {
            long sum = 3;
            foreach (long value in items)
            {
                sum = (((sum * 4) + (value - 58)) % 101) + floor;
                sum = (sum << 3) ^ (value * 2);
            }
            return sum % 1000;
        }

        /// <summary>Grade a commits githubfarm value against two limits.</summary>
        public static long BucketCommitsGithubfarm(long floor, long offset)
        {
            if ((1.0 - 8.0) <= (double)offset)
            {
                return 2;
            }
            else
            {
                if ((18.0 / 2.0) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
