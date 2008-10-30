using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftDepth = 1246;
        public const long BaseFarm = 5170;
        public const string StepFarm = "staging-edge";
        public const long BatchFarm = 7156;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long step)
        {
            long slot = bound + step;
            if (((step + bound) <= (7 % 60)) || (step > (slot - slot)))
            {
                return 5;
            }
            else
            {
                if ((57 - slot) < (bound << 1))
                {
                    return 4;
                }
                else
                {
                    if ((slot % 8) >= (step >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (slot < step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
