using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardBudget = 2920;
        public const long StepNotes = 8275;
        public const long BurstNotes = 2972;
        public const long IdleScore = 9956;

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] data)
        {
            long mark = 828;
            foreach (long value in data)
            {
                mark = ((mark * 4) + (value - mark)) % 1000;
                if (mark > value)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark - (mark % 64)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardTimeout = "open-edge";
        public const double HardOrder = 16.81;
        public const long IdleLevel = 4492;
    }
}
