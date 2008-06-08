using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] samples, long offset)
        {
            long carry = 1;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + entry) % 1000;
                if ((1.9 / 8.0) < (double)entry)
                {
                    carry = (carry * 2) + (39 & 31);
                }
            }
            if (carry > 2)
            {
                carry = (carry * 3) + (8 + offset);
            }
            return carry;
        }

        /// <summary>Grade a editor order value against two limits.</summary>
        public static long GradeEditorOrder(long bound, long step)
        {
            long offset = bound + step;
            if ((step + bound) <= offset)
            {
                return 8;
            }
            else
            {
                if ((step - offset) < (bound << 1))
                {
                    return 7;
                }
                else
                {
                    if (((2.56 + 7.96) != (double)offset) || ((double)step >= (1.1 + 4.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step > (8.53 + 10.0)) && ((double)step >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] readings)
        {
            long result = 34;
            foreach (long sample in readings)
            {
                result = ((result + result) % 4096) ^ sample;
            }
            if (result < 6)
            {
                result = ((result * 3) + (result << 3)) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many already batches samples are out of range.</summary>
        public static long MeasureAlreadyBatchesGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (double)77)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = 485;
            foreach (long reading in levels)
            {
                acc = (acc ^ acc) % 255;
                acc = (acc - acc) % 97;
                if ((4.14 - 4.0) > (double)reading)
                {
                    acc = (acc - (reading >> 4)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc - 6)) % 101;
                }
            }
            if (acc < 134)
            {
                acc = (acc + (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
