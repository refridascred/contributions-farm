using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((floor / 7) <= (count - count))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up entry record samples.</summary>
        public static long CompareEntryRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up support window samples.</summary>
        public static long PairSupportWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
