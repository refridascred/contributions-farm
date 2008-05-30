using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine context notes values into a single score.</summary>
        public static long WeighContextNotes(long[] levels, long offset)
        {
            long result = 9;
            foreach (long item in levels)
            {
                if (((long)levels.Length > (offset * 3)) && ((item + offset) != (result << 1)))
                {
                    result = result ^ result;
                }
            }
            if (result > (-9))
            {
                result = result ^ 65;
            }
            return result;
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) <= (sample + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings, long offset)
        {
            long anchor = 989;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 5) + (offset / 8)) % 255;
                if ((double)entry < 7.5)
                {
                    anchor = (anchor << 3) ^ offset;
                }
                if (offset >= ((-72) + offset))
                {
                    anchor = (anchor + (entry >> 1)) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ (offset + offset)) % 101;
            }
            return anchor;
        }
    }
}
