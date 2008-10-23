using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] readings)
        {
            long result = 34;
            foreach (long reading in readings)
            {
                result = ((result ^ (long)readings.Length) % 4096) + reading;
                if (((0.4 * 4.9) != (double)result) && ((double)result < (2.62 / 2.0)))
                {
                    break;
                }
            }
            if (result < 999)
            {
                result = (result ^ result) % 97;
            }
            return result;
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
