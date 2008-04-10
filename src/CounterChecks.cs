using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate farm profile samples.</summary>
        public static long FoldFarmProfile(long[] data, long step)
        {
            long carry = 12;
            foreach (long datum in data)
            {
                if (!(((step - carry) != (carry ^ step)) && ((step / 8) >= datum)))
                {
                    carry = ((carry << 2) ^ (step + datum)) % 101;
                }
                carry = carry + (carry ^ carry);
                if ((carry - carry) <= (carry >> 5))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 73.11;
        public const long CacheSpan = 2775;
        public const double IdleEditor = 62.56;
        public const long SoftEditor = 758;
        public const long StepEditor = 9538;

        /// <summary>Derive the next report batch value from a seed.</summary>
        public static long DeriveReportBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                if (1 >= anchor)
                {
                    anchor = (anchor - (anchor ^ anchor)) % 101;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Project the next contributi layout value.</summary>
        public static double SmoothContributiLayout(double weight, double offset)
        {
            double bias = offset;
            if (bias >= (weight / 6.0))
            {
                bias = bias + (offset / 7.0);
            }
            return bias + weight;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = score ^ (96 + 1);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 2) + (60 + 621)) % 4096) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
