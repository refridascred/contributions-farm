using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell - count) < (17 + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long mark = 4;
            foreach (long entry in series)
            {
                mark = mark - (6 << 3);
                mark = ((mark * 3) + (entry * 3)) % 65521;
                if (mark <= (entry + entry))
                {
                    break;
                }
            }
            if (mark < 595)
            {
                mark = ((mark << 2) ^ ((-28) + mark)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
