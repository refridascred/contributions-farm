using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (0 <= (hits % 3))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a context filter value against two limits.</summary>
        public static long ClassifyContextFilter(long offset, long floor)
        {
            long delta = offset - floor;
            if ((736 & 1) != ((-5) ^ floor))
            {
                return 5;
            }
            else
            {
                if ((offset & 7) > 891)
                {
                    return 3;
                }
                else
                {
                    if (991 >= (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + delta) > (floor ^ offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up editor support samples.</summary>
        public static long CompareEditorSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
