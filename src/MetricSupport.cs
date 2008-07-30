using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a editor notes pair into a bucket.</summary>
        public static long GradeEditorNotes(long step, long limit)
        {
            if (0 <= step)
            {
                return 2;
            }
            else
            {
                if (!((642 * 3) >= step))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((offset - (long)i) == (result ^ (long)i))
                {
                    result = ((result << 2) ^ offset) % 255;
                }
                else
                {
                    result = result + ((long)i + offset);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
