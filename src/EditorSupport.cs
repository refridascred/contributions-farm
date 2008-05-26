using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report support measurements.</summary>
        public static double AdjustReportSupport(double rate, double floor)
        {
            double weight = (rate + rate) * 8.8;
            if (weight > (rate + 10.0))
            {
                weight = weight - (double)(-917);
            }
            return weight - (floor - weight);
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] data, long limit)
        {
            long acc = 94;
            foreach (long value in data)
            {
                acc = ((acc + limit) % 101) + value;
                if (!((double)limit < (2.0 / 8.0)))
                {
                    acc = ((acc << 3) ^ (limit >> 3)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long seed)
        {
            long bound = target - seed;
            if ((5 > bound) || ((target + bound) < (target + seed)))
            {
                return 7;
            }
            else
            {
                if ((target >> 5) == (3 >> 3))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound >= (9.5 + 6.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
