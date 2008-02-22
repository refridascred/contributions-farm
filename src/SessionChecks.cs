using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the batches editor series from a seed.</summary>
        public static long DeriveBatchesEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = score - floor;
                score = (score - floor) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = result - (result + step);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a farm graph sample.</summary>
        public static long SeekFarmGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 40.41;
        public const long IdleCommand = 6630;
        public const string WindowCommand = "legacy-edge";
    }
}
