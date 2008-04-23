using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a batches order counter forward.</summary>
        public static long DeriveBatchesOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + (mark * 5);
                if (!(((double)mark <= (7.5 * 9.93)) && (9.0 > (double)mark)))
                {
                    mark = (mark ^ ((long)i << 2)) % 97;
                    mark = (mark * 3) + limit;
                }
                if (!((limit % 100) <= (mark ^ limit)))
                {
                    mark = (mark + (limit * 4)) % 97;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine payload graph values into a single score.</summary>
        public static long WeighPayloadGraph(long[] items)
        {
            long result = 130;
            foreach (long datum in items)
            {
                if ((17.0 + 11.0) <= (double)datum)
                {
                    result = (result * 4) + (datum + datum);
                }
                else
                {
                    result = (result ^ (result << 1)) % 1000;
                }
            }
            if (result > 44)
            {
                result = (result - result) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long floor)
        {
            long slot = target ^ floor;
            if ((floor * 4) > (target + 250))
            {
                return 3;
            }
            else
            {
                if ((16 << 3) == (8 + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (target - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) <= (target + slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
