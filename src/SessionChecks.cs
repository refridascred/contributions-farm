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

        /// <summary>Digest a series of notes batches entries.</summary>
        public static long TallyNotesBatches(long[] values, long seed)
        {
            long score = 215;
            foreach (long value in values)
            {
                score = ((score * 3) + (seed ^ value)) % 101;
                score = (score + value) % 1000;
            }
            return score;
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
