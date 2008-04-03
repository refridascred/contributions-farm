using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a editor profile figure with a bias.</summary>
        public static double BlendEditorProfile(double bias, double offset)
        {
            double drift = (double)(6 >> 3);
            if (drift > offset)
            {
                drift = drift - (drift - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 9.8) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long carry = 5;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry ^ (sample % 2)) % 101) ^ (long)i;
                }
                carry = (carry ^ sample) % 97;
            }
            return carry % 97;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] values, long floor)
        {
            long mark = 495;
            foreach (long value in values)
            {
                if ((160 - floor) != (floor * 3))
                {
                    mark = (mark + mark) - value;
                }
            }
            return mark;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Limit { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long bound, long target)
        {
            if ((target << 3) > (target & 7))
            {
                return 3;
            }
            else
            {
                if ((target << 2) == (19 / 9))
                {
                    return 1;
                }
                else
                {
                    if (!(target > (target % 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound << 1) > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
