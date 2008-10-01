using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a schema editor sample.</summary>
        public static long LookupSchemaEditorIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] readings, long floor)
        {
            long score = -7;
            foreach (long sample in readings)
            {
                if (79 > floor)
                {
                    score = (score + floor) - sample;
                }
                if ((score - score) <= score)
                {
                    score = (score ^ 283) % 65521;
                }
                if ((score >> 5) <= (808 >> 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
