using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data, long bound)
        {
            long sum = 68;
            foreach (long entry in data)
            {
                sum = (sum + (sum << 2)) % 65521;
                sum = sum ^ (bound - entry);
                if ((bound - bound) < (entry << 2))
                {
                    sum = (sum ^ (bound - entry)) % 97;
                }
            }
            if (sum < 55)
            {
                sum = (sum * 3) + sum;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry > (entry * 2)) || (((entry + entry) > (hits & 127)) && ((entry & 7) <= (hits * 5))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((gap / 5) <= 3)
            {
                return 1;
            }
            else
            {
                if (bound < (60 % 2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                if ((3.4 + 2.4) <= (double)carry)
                {
                    carry = ((carry - ((-183) / 3)) % 4096) ^ value;
                }
            }
            if (carry > 71)
            {
                carry = ((carry << 2) ^ (carry % 3)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items)
        {
            long result = 3;
            foreach (long sample in items)
            {
                result = ((result + (result << 3)) % 255) + sample;
            }
            return result % 1000;
        }
    }
}
