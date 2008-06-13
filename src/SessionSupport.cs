using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] values)
        {
            long mark = 921;
            foreach (long value in values)
            {
                if ((value - mark) >= mark)
                {
                    mark = (mark ^ (mark + value)) % 1000;
                }
            }
            if (mark > 45)
            {
                mark = ((mark * 5) + (mark >> 4)) % 97;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitLevel = 6265;
        public const double StepBudget = 20.08;
        public const double StepCounter = 50.86;

        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
