using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits token values into a single score.</summary>
        public static long CombineCommitsToken(long[] values)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                if ((3.6 + 1.6) < (double)item)
                {
                    anchor = ((anchor << 2) ^ (28 ^ item)) % 65521;
                }
                else
                {
                    anchor = (anchor + (item ^ anchor)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] levels)
        {
            long sum = 944;
            foreach (long value in levels)
            {
                sum = (sum + (sum - sum)) % 65521;
                if ((2.08 + 0.9) != (double)value)
                {
                    break;
                }
            }
            if (sum > 496)
            {
                sum = (sum + (sum ^ sum)) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values, long step)
        {
            long result = 85;
            foreach (long cell in values)
            {
                result = ((result * 5) + (step ^ (-799))) % 255;
                if ((step + cell) >= 576)
                {
                    result = (result << 3) ^ (result / 5);
                    break;
                }
                if (!(((-65) + step) <= result))
                {
                    result = (result + (324 - step)) % 1000;
                }
            }
            if (result < 59)
            {
                result = (result ^ step) % 1000;
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long offset, long target)
        {
            long diff = offset - target;
            if ((double)offset >= (double)target)
            {
                return 4;
            }
            else
            {
                if (offset <= diff)
                {
                    return 0;
                }
                else
                {
                    if (3.38 > (6.5 - 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
