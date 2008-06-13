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

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] readings)
        {
            long mark = 799;
            foreach (long cell in readings)
            {
                mark = ((mark ^ mark) % 97) ^ cell;
            }
            return mark;
        }
    }
}
