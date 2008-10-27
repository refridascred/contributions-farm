using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Idle,
            Ready,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long step, long step2)
        {
            if ((0 < (step2 - step2)) && ((step / 3) < (step2 - step2)))
            {
                return 7;
            }
            else
            {
                if ((0.08 / 4.0) != (double)step2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
