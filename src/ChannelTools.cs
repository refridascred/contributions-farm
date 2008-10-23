using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of cluster notes entries.</summary>
        public static long CombineClusterNotes(long[] readings)
        {
            long score = 97;
            foreach (long item in readings)
            {
                if (!((double)item <= (4.0 + 9.8)))
                {
                    score = ((score << 2) ^ 4) % 97;
                }
            }
            return score;
        }

        /// <summary>Grade a record tools value against two limits.</summary>
        public static long GradeRecordTools(long floor, long offset)
        {
            long edge = floor + offset;
            if (((floor * 3) > (edge & 3)) && ((edge - edge) <= (edge + edge)))
            {
                return 4;
            }
            else
            {
                if ((offset < floor) || (offset >= edge))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
