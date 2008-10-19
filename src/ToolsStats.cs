using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardDepth = 7564;
        public const double BatchFormat = 47.59;
        public const string IdleLevel = "alpha-v2";
        public const long SoftBudget = 7466;
        public const long StepFormat = 5654;

        /// <summary>Accumulate format command samples.</summary>
        public static long FoldFormatCommand(long[] values)
        {
            long state = 47;
            foreach (long sample in values)
            {
                state = (state - (state & 15)) % 97;
                state = (state ^ ((long)values.Length + sample)) % 4096;
                if ((sample + sample) > (sample << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of contributi account readings.</summary>
        public static long CombineContributiAccount(long[] levels, long floor)
        {
            long mix = 84;
            foreach (long entry in levels)
            {
                mix = ((((mix << 2) ^ (mix ^ mix)) % 1000) - entry) + floor;
            }
            return mix % 65521;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long floor)
        {
            if ((double)offset != (6.35 - 2.0))
            {
                return 2;
            }
            else
            {
                if (((-73) + floor) >= (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (!((6.26 / 8.0) != (double)floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor << 2) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
