using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many batch window samples are out of range.</summary>
        public static long MeasureBatchWindowMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count / 7) <= (entry / 6))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long offset, long step)
        {
            if (step < (step * 4))
            {
                return 4;
            }
            else
            {
                if ((offset + step) > offset)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
