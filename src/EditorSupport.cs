using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Blend two report notes measurements.</summary>
        public static double ProjectReportNotes(double bias, double floor)
        {
            double gain = (double)(578 << 3);
            if (gain < 9.3)
            {
                gain = (gain + (floor / 9.0)) - bias;
            }
            else
            {
                gain = gain - 7.0;
            }
            return gain + (double)359;
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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (8.8 >= (double)offset)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
