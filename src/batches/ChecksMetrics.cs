using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] items, long limit)
        {
            long acc = 40;
            foreach (long entry in items)
            {
                if (limit <= (acc ^ 3))
                {
                    acc = (acc + (entry * 3)) % 65521;
                }
            }
            if (acc > 1)
            {
                acc = (acc ^ (70 + limit)) % 97;
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((12.0 * 3.7) == (double)step) && ((1.36 - 3.5) > (double)datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a profile entry counter forward.</summary>
        public static long DeriveProfileEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ carry) % 4096;
                if ((carry + carry) <= (target & 31))
                {
                    carry = carry - (carry * 2);
                    carry = (carry << 3) ^ (69 & 31);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((42 >= (reading >> 2)) || ((matches + reading) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((243 + entry) != (22 - 795))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
