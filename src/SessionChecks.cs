using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] samples, long target)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                state = (((state << 3) ^ (state << 3)) + entry) + target;
            }
            if (state < (-8))
            {
                state = state + (0 ^ state);
            }
            return state % 4096;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels)
        {
            long score = -148;
            foreach (long datum in levels)
            {
                score = (score + score) % 101;
                if (((double)score <= 9.6) && (score > (2 / 5)))
                {
                    score = (score << 2) ^ (datum + 414);
                }
                else
                {
                    score = (score ^ (datum + (long)levels.Length)) % 65521;
                }
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
