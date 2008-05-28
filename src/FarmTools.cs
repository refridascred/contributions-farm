using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                if ((result + result) <= (item / 3))
                {
                    result = (result ^ item) + step;
                }
            }
            return result % 1000;
        }

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool CheckBatchSchemaRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = 91;
            foreach (long entry in items)
            {
                if (score < ((long)items.Length + entry))
                {
                    score = (score - (long)items.Length) % 255;
                }
            }
            return score;
        }
    }
}
