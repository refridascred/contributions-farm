using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long GradePayloadOrder(long limit, long offset)
        {
            long cur = limit + offset;
            if ((cur - cur) < cur)
            {
                return 3;
            }
            else
            {
                if ((offset - cur) < (658 + offset))
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 5) == (limit + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading ^ 552) != (seen % 2))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((origin < (reading - 50)) || ((double)origin == (1.4 * 3.4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload order samples are out of range.</summary>
        public static long MeasurePayloadOrderMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (cell >= (504 >> 4))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Locked,
            Ready,
            Queued,
        }
    }
}
