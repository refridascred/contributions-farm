using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((((-98) + step) <= offset) || (offset >= (step + step)))
            {
                return 8;
            }
            else
            {
                if ((step >> 1) == (offset - 4))
                {
                    return 6;
                }
                else
                {
                    if (offset < (step - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset + 5) <= offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleDepth = 52.28;
        public const string DefaultRatio = "legacy";
        public const string SoftCount = "primary-edge";
        public const long MaxTimeout = 7138;
        public const double BurstBuffer = 84.28;
    }
}
