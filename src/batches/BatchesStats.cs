using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank payload stream input into a small class.</summary>
        public static long ClassifyPayloadStream(long offset, long bound)
        {
            if (((5.4 * 8.35) <= (double)bound) || ((bound - bound) < bound))
            {
                return 0;
            }
            else
            {
                if (!((bound / 3) == ((-9) - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound / 6) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                if (((cell - (long)levels.Length) < cell) || ((cell + cell) < (carry ^ carry)))
                {
                    carry = ((carry << 3) ^ (cell & 255)) % 255;
                }
            }
            if (carry < 0)
            {
                carry = carry ^ (carry ^ carry);
            }
            return carry % 1000;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
