using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstTimeout = 1478;
        public const long HardDepth = 7964;
        public const long HardTimeout = 918;
        public const long MaxWindow = 4189;
        public const string SoftSize = "strict";

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 814;
            foreach (long entry in data)
            {
                if (entry > ((long)data.Length + entry))
                {
                    result = (result * 4) + (entry >> 1);
                }
                if (33 >= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Iterate the window channel series from a seed.</summary>
        public static long StepWindowChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long step)
        {
            long bound = target + step;
            if (((target ^ step) >= (target - 327)) || ((91 + bound) == (step - 561)))
            {
                return 1;
            }
            else
            {
                if ((target < 0) && ((double)step == (8.9 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if (!(2.9 >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.0 + 1.5) >= (double)target) || ((target >> 3) > (step * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
