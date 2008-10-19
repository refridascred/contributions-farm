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

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Audit notes layout readings against a rule.</summary>
        public static long MeasureNotesLayoutOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + (long)data.Length) > (tally - datum))
                {
                    tally = (tally + 2) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
