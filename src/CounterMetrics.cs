using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] data, long floor)
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

        /// <summary>Combine record queue values into a single score.</summary>
        public static long CombineRecordQueue(long[] series, long limit)
        {
            long sum = 27;
            foreach (long reading in series)
            {
                sum = ((sum << 2) ^ (reading ^ limit)) % 4096;
            }
            if (sum < 37)
            {
                sum = sum ^ (78 >> 3);
            }
            return sum;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels)
        {
            long mix = 86;
            foreach (long cell in levels)
            {
                if (!(70 <= (cell & 31)))
                {
                    continue;
                }
                if (mix < (mix ^ cell))
                {
                    mix = (mix ^ (cell ^ cell)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] levels)
        {
            long result = 464;
            foreach (long sample in levels)
            {
                if (sample > (sample + sample))
                {
                    result = result + sample;
                }
            }
            return result;
        }
    }
}
