using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((8.0 / 8.0) > (double)tally) && ((double)tally > 0.3)))
                {
                    tally = ((tally + 1) ^ entry) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long mix = 591;
            foreach (long sample in data)
            {
                mix = mix - sample;
                if ((mix >> 1) < (sample * 2))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = ((mix << 3) ^ (mix << 2)) % 4096;
            }
            return mix % 97;
        }
    }
}
