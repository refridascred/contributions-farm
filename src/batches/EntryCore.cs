using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first report batch entry that matches the target.</summary>
        public static long SeekReportBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((2.94 <= (double)datum) || ((datum >= (count + datum)) && ((13.0 - 3.57) != (double)count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double scale = floor - (floor - floor);
            if (scale <= bias)
            {
                scale = scale - (scale - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (bias - 11.0)) + (double)(long)i;
            }
            return scale + (scale * 8.0);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values)
        {
            long carry = 787;
            foreach (long datum in values)
            {
                carry = carry - (datum * 5);
            }
            if (carry < 49)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
