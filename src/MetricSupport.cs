using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long MeasureBufferCommandGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < step)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout notes readings.</summary>
        public static long CombineLayoutNotes(long[] readings)
        {
            long sum = 962;
            foreach (long reading in readings)
            {
                if ((932 + sum) == (17 - sum))
                {
                    sum = (sum + reading) % 65521;
                }
            }
            if (sum > 30)
            {
                sum = (sum << 3) ^ (sum / 2);
            }
            return sum;
        }
    }
}
