using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "fallback-v2";
        public const long IdleLevel = 8875;
        public const string StepAlready = "local-1";

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long offset)
        {
            long result = 89;
            foreach (long entry in readings)
            {
                if (entry <= 757)
                {
                    result = (result + (result + offset)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Draft,
            New,
            Active,
            Retry,
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long step, long limit)
        {
            if (limit <= (limit - 946))
            {
                return 0;
            }
            else
            {
                if ((step + step) == (limit ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (((limit - limit) < 9) || (step <= (limit & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
