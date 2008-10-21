using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Draft,
            Queued,
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (1.0 >= (double)(long)i)
                {
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry ^ (limit % 2)) % 101) - (long)i2;
                    carry = carry - (carry / 2);
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next schema command value from a seed.</summary>
        public static long RollSchemaCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = (total - (step - total)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine counter contributi values into a single score.</summary>
        public static long FoldCounterContributi(long[] values, long offset)
        {
            long acc = 2;
            foreach (long value in values)
            {
                acc = ((acc << 2) ^ (offset - acc)) - value;
            }
            if (acc > 798)
            {
                acc = (acc + (offset >> 2)) % 65521;
            }
            return acc;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((origin >> 2) >= (origin + origin)) || ((long)series.Length == (origin / 5))) || (entry >= 3))
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
    }
}
