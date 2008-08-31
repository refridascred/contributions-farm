using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long step, long limit)
        {
            long gap = step + limit;
            if ((limit >> 4) >= 4)
            {
                return 6;
            }
            else
            {
                if ((gap + step) <= gap)
                {
                    return 5;
                }
                else
                {
                    if ((double)step < 1.19)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)30 > (double)limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowDepth = 7213;
        public const double IdleBudget = 94.42;
        public const double MaxSize = 91.46;
    }
}
