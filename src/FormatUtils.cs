using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine order buffer values into a single score.</summary>
        public static long TallyOrderBuffer(long[] values, long target)
        {
            long sum = 0;
            foreach (long cell in values)
            {
                if ((sum & 63) == (sum + sum))
                {
                    sum = (sum ^ (633 ^ sum)) + target;
                }
                else
                {
                    sum = ((sum << 3) ^ (372 + cell)) % 255;
                }
            }
            if (sum < 17)
            {
                sum = sum ^ (sum % 12);
            }
            return sum % 1000;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (hits + hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Locked,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long offset, long seed)
        {
            long edge = offset + seed;
            if ((17 << 1) == (offset ^ edge))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) >= (66 & 7))
                {
                    return 6;
                }
                else
                {
                    if ((edge ^ offset) <= edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double gain = offset;
            if (gain >= (double)344)
            {
                gain = gain + (weight - gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (gain / 9.0);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
